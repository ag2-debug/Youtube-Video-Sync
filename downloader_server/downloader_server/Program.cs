using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Security.Cryptography;
using System.Diagnostics;
using System.IO;

namespace Multi_Server
{
    class Program
    {
        private static Socket _serverSocket;
        private static readonly List<Socket> _clientSockets = new List<Socket>();
        private const int _BUFFER_SIZE = 2048;
        private static int _PORT = 2016;
        private static readonly byte[] _buffer = new byte[_BUFFER_SIZE];

        private static String videoRetInfo="";

        private static String username, password;

        private static String CalcMd5(String text)
        {
            // using System.Security.Cryptography; 使用加密库
            String md5 = "";
            MD5 md5_text = MD5.Create();
            byte[] temp = md5_text.ComputeHash(System.Text.Encoding.ASCII.GetBytes(text)); //计算MD5 Hash 值

            for (int i = 0; i < temp.Length; i++)
            {
                md5 += temp[i].ToString("x2"); //转码 每两位转一次16进制
            }
            return md5;
        }

        static void Main(String[] args)
        {
            // Console.Title = "Server";
            if (args.Length != 2)
                Console.WriteLine("Please run this program with [ username  password ]");
            else
            {
                username = args[0];
                password = args[1];
            //    _PORT = Convert.ToInt32(args[2]);
                username = CalcMd5(username);
                password = CalcMd5(password);
                //  Console.WriteLine(username);
                //  Console.WriteLine(password);
                SetupServer();
                Console.ReadLine(); // When we press enter close everything 线程异步技术
                CloseAllSockets();
            }


        }

        private static void SetupServer()
        {
            // Console.WriteLine("Setting up server...");
            _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _serverSocket.Bind(new IPEndPoint(IPAddress.Any, _PORT));
            _serverSocket.Listen(50); //设置监听的数量
            _serverSocket.BeginAccept(AcceptCallback, null);
            // Console.WriteLine("Server setup complete");
        }

        /// <summary>
        /// Close all connected client (we do not need to shutdown the server socket as its connections
        /// are already closed with the clients)
        /// </summary>
        private static void CloseAllSockets()
        {
            foreach (Socket socket in _clientSockets)
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }

            _serverSocket.Close();
        }

        private static void AcceptCallback(IAsyncResult AR)
        {
            Socket socket;

            try
            {
                socket = _serverSocket.EndAccept(AR);
            }
            catch (ObjectDisposedException) // I cannot seem to avoid this (on exit when properly closing sockets)
            {
                return;
            }

            _clientSockets.Add(socket);
            socket.BeginReceive(_buffer, 0, _BUFFER_SIZE, SocketFlags.None, ReceiveCallback, socket);
            // Console.WriteLine("Client connected, waiting for request...");
            _serverSocket.BeginAccept(AcceptCallback, null);
        }

        private static void ReceiveCallback(IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            int received;

            try
            {
                received = current.EndReceive(AR);
            }
            catch (SocketException)
            {
                // Console.WriteLine("Client forcefully disconnected");
                current.Close(); // Dont shutdown because the socket may be disposed and its disconnected anyway
                _clientSockets.Remove(current);
                return;
            }

            byte[] recBuf = new byte[received];
            Array.Copy(_buffer, recBuf, received);
            string text = Encoding.ASCII.GetString(recBuf); //接收到的数据

            //  Console.WriteLine("Receive Data: " + text);
            //  Console.WriteLine("Received Text: " + text);

            /*    if (text.ToLower() == "get time") // Client requested time
                {
                    Console.WriteLine("Text is a get time request");
                    byte[] data = Encoding.ASCII.GetBytes(DateTime.Now.ToLongTimeString());
                    current.Send(data);
                    Console.WriteLine("Time sent to client");
                }
                else if (text.ToLower() == "exit") // Client wants to exit gracefully
                {
                    // Always Shutdown before closing
                    current.Shutdown(SocketShutdown.Both);
                    current.Close();
                    _clientSockets.Remove(current);
                   // Console.WriteLine("Client disconnected");
                    return;
                }
                else
                {
                  //  Console.WriteLine("Text is an invalid request");
                    byte[] data = Encoding.ASCII.GetBytes("Invalid request");
                    current.Send(data);
                   // Console.WriteLine("Warning Sent");
                }
                */

            //处理 text text格式为 【 用户名的MD5 空格一个 密码的MD5 】
            String[] list = text.Split(' ');
            if (username.Equals(list[0]) && password.Equals(list[1]))
            {
                //  current.Send(Encoding.ASCII.GetBytes("Link"+url));

                String url = list[2]; //youtube 视频链接的 base64编码地址
                
                //对url进行解码 下载工作
                if (CreateRemoteTask(url)) //如果创建任务成功
                {
                    videoRetInfo = Convert.ToBase64String(Encoding.UTF8.GetBytes(videoRetInfo));
                    current.Send(Encoding.ASCII.GetBytes(videoRetInfo)); //此行必须 因为socket必须返回一个字符流 用来结束链接
                    
                }
                else 
                {
                    current.Send(Encoding.ASCII.GetBytes("no")); //返回no 创建任务失败
                }
                


            }
            else
            {
                current.Send(Encoding.ASCII.GetBytes("no"));
            }
            //  current.BeginReceive(_buffer, 0, _BUFFER_SIZE, SocketFlags.None, ReceiveCallback, current);
        }

        private static Boolean CreateRemoteTask(String base64_url)
        {
           String url = Encoding.ASCII.GetString(Convert.FromBase64String(base64_url));
           String execFile = "youtube-dl"; //可执行程序路径
           String videoList = ListVideoFormat(execFile, url);
           //Console.WriteLine(videoList);
           String[] list = videoList.Split('\n');
           String lastLine = list[list.Length - 2]; //获取最佳视频格式输出
          // Console.WriteLine(list[list.Length-2]);
            //对lastLine进行 信息筛选 获取格式代码 

           String[] lastLineList = lastLine.Split(' ');
          // Console.WriteLine(lastLine + "\n" + lastLineList.Length.ToString());
           String formatCode = lastLineList[0];//获取最优视频下载代码
           if (IsNum(formatCode))
           {
               // 最优格式码验证成功 执行下载
              // String command = "nohup ./" + execFile + " -f " + formatCode + " " + url+"&"; //构造Linux后台命令执行路径
               String retData=CreateDownloadTask(execFile, formatCode, url);
               videoRetInfo = retData; //全局视频下载信息 赋值反馈
               //Console.WriteLine(retData);
               return true;
           }
           else
           {
               return false;
           }


        }

        private static String ListVideoFormat(String ExeFileName, String url) //传递base64编码链接
        {
            //创建进程 开启用户账户信息测试
            Process prc = new Process();
            prc.StartInfo.FileName = ExeFileName;

            prc.StartInfo.Arguments = "-F "+url;
            prc.StartInfo.CreateNoWindow = true;
            prc.StartInfo.UseShellExecute = false;
            prc.StartInfo.RedirectStandardOutput = true;
            // prc.Exited += new EventHandler(prc_Exited);
            prc.Start();
            prc.WaitForExit();
            //  prc.Exited += new EventHandler(prc_Exited);
            String data = prc.StandardOutput.ReadToEnd();
            return data;
        }

        private static String CreateDownloadTask(String ExeFileName,String formatCode, String url) //传递base64编码链接
        {
            //创建进程 开启用户账户信息测试
            Process prc = new Process();
            prc.StartInfo.FileName = ExeFileName;

            prc.StartInfo.Arguments = "-f " +formatCode+" "+ url;
            prc.StartInfo.CreateNoWindow = true;
            prc.StartInfo.UseShellExecute = false;
            prc.StartInfo.RedirectStandardOutput = true;
            // prc.Exited += new EventHandler(prc_Exited);
            prc.Start();
            
            
          //  prc.WaitForExit();
            //  prc.Exited += new EventHandler(prc_Exited);
            String data;
            do
            {
                data = prc.StandardOutput.ReadLine();
            } while (!(data[0] == '[' && data[1] == 'd'));
           // String temp = prc.StandardOutput.ReadLine();
            String videoInfo = "";
            if (data[11] == 'D')
                for (int i = 24; i < data.Length; i++)
                    videoInfo += data[i];
            else
            {
                videoInfo = "Existed!";
            }


            data = prc.StandardOutput.ReadLine();
            data = prc.StandardOutput.ReadLine();

            String[] fileSize = data.Split(' '); //获取文件大小
          //  for (int i = 0; i < fileSize.Length; i++)
            //    Console.WriteLine(fileSize[i]);
            if (fileSize.Length <= 4)
                data = fileSize[fileSize.Length - 1];
            //   else if (fileSize.Length <= 6)
            //  data = fileSize[fileSize.Length - 1];
            else if (fileSize.Length > 5)
                data = fileSize[5];
            else
                data = "Can not get file size!";
            String SyncfileSize=data;
             //Console.WriteLine(data);  //输出文件大小
             return videoInfo + "~" + SyncfileSize;   //这种分隔符
        }
        private static Boolean IsNum(String text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= '0' && text[i] <= '9')
                {
                    continue;
                }
                else
                    return false;
            }
            return true;
        }

    }
}
