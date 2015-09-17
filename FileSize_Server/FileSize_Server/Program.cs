using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Security.Cryptography;
using System.IO;


namespace Multi_Server
{
    class Program
    {
        private static Socket _serverSocket;
        private static readonly List<Socket> _clientSockets = new List<Socket>();
        private const int _BUFFER_SIZE = 2048;
        private static int _PORT = 2017; //FileSize 端口
        private static readonly byte[] _buffer = new byte[_BUFFER_SIZE];

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
               // _PORT = Convert.ToInt32(args[2]);
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

            //处理 text text格式为 【 用户名的MD5 空格一个 密码的MD5 文件名的Base64 编码 】
            String[] list = text.Split(' '); //数据分割
            if (username.Equals(list[0]) && password.Equals(list[1]))
            {

                if (list.Length == 3)
                {
                    String fileName = Encoding.UTF8.GetString(Convert.FromBase64String(list[2])); //获取文件名
                    if (File.Exists(fileName))
                    {
                        FileInfo fi = new FileInfo(fileName); 
                        current.Send(Encoding.ASCII.GetBytes(((double)fi.Length/1024/1024).ToString("f2"))); //返回MB大小 没有单位
                    }
                    else
                    {
                        current.Send(Encoding.ASCII.GetBytes("Finish!")); //文件下载完毕
                    }
                }
                else
                {
                 current.Send(Encoding.ASCII.GetBytes("no"));
                 }

                
            }
            else
            {
                current.Send(Encoding.ASCII.GetBytes("no"));
            }
            //  current.BeginReceive(_buffer, 0, _BUFFER_SIZE, SocketFlags.None, ReceiveCallback, current);
        }
    }
}
