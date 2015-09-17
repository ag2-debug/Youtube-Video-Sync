using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Security.Cryptography;


namespace Multi_Client
{
    class Program
    {
        private static readonly Socket _clientSocket = new Socket
            (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static String username, password, Send_Info,url;
        private static int _PORT = 2016;
        private static String domain = "icorer.com";
        private static String responseText = "";
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


            /*   Console.Write("UserName:");
               username=Console.ReadLine();
               Console.Write("Password:");
               password = Console.ReadLine();
               */

            if (args.Length == 3)
            {
                username = args[0];
                password = args[1];
                url = args[2];
              //  _PORT = Convert.ToInt32(args[2]);
                username = CalcMd5(username);
                password = CalcMd5(password);
                Send_Info = username + " " + password + " "+url; //传递给服务器的验证数据【用户名 密码 url编码】
                //   Console.WriteLine(Login_info);
                if (ConnectToServer())
                {

                    RequestLoop();
                    Exit();
                }
                else
                {
                    Console.WriteLine("Link Error");
                }


            }
            else
            {
                Console.WriteLine("args error");
            }


        }

        private static Boolean ConnectToServer()
        {
            int attempts = 0;

            // while (!_clientSocket.Connected)
            //  {
            try
            {
                attempts++;
                //  Console.WriteLine("Connection attempt " + attempts);
                _clientSocket.Connect(Dns.GetHostAddresses(domain)[0], _PORT);
                return true;
            }
            catch (SocketException)
            {
                return false;
            }
            //  }

            //  Console.Clear();
            //  Console.WriteLine("Connected");
        }

        private static void RequestLoop()
        {
            // Console.WriteLine(@"<Type ""exit"" to properly disconnect client>");

            //   while (true)
            // {
            SendRequest();
            if (ReceiveResponse())
            {
                Console.WriteLine(responseText); //创建任务成功 I/O显示任务信息
            }
            else
            {
                Console.WriteLine("no"); //用户验证失败 创建任务失败
            }
            //     Console.ReadLine();
            Exit();
            //  }
        }

        /// <summary>
        /// Close socket and exit app
        /// </summary>
        private static void Exit()
        {
            SendString("exit"); // Tell the server we re exiting
            _clientSocket.Shutdown(SocketShutdown.Both);
            _clientSocket.Close();
            Environment.Exit(0);
        }

        private static void SendRequest()
        {
            //  Console.Write("Send a request: ");
            string request = Send_Info;
            SendString(request);

            if (request.ToLower() == "exit")
            {
                Exit();
            }
        }

        /// <summary>
        /// Sends a string to the server with ASCII encoding
        /// </summary>
        private static void SendString(string text)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(text);
            _clientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        private static Boolean ReceiveResponse()
        {
            // String ret = "error";
            var buffer = new byte[2048];
            int received = _clientSocket.Receive(buffer, SocketFlags.None);
            if (received == 0) return false;
            var data = new byte[received];
            Array.Copy(buffer, data, received);
            string text = Encoding.ASCII.GetString(data);
            responseText = text;
            if (text.Equals("no")) //远程用户验证失败
            {
                return false;
            }
            else
            {
                return true;
            }

            //  Console.WriteLine(text);
        }
    }
}
