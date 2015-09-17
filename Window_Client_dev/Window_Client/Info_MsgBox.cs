using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Threading;

namespace Window_Client
{
    public partial class Info_MsgBox : Skin_Mac
    {
        public static String username;
        public static String password;
        public static String fileTotalSize;

        public static double CloudFileSize=0; //云端数据文件大小

        public int x;
        public int y;
        public Info_MsgBox()
        {
            InitializeComponent();
        }

        private void Info_MsgBox_Load(object sender, EventArgs e)
        {

            if (x != 0 && y != 0)
            {
                this.Location = new Point(x, y);
            }
            
            this.Text = title.Text;
        }

 

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (skinTextBox1.Text.Length >= 43)
            {
                String url = "";
                for (int i = 0; i < 43; i++)
                {
                    url += skinTextBox1.Text[i];
                }
                skinTextBox1.Text = url;

                if (!CheckUrl(url))
                {
                    title.Text = "链接格式错误！";
                    skinTextBox1.Text = "";
                }
                else
                {
                    title.Text = "正在传送数据...";
                    String base64_url = Convert.ToBase64String(Encoding.ASCII.GetBytes(url));
                    String ret = CreateRemoteTask("UrlSender.exe", username, password, base64_url);
                    if (ret.Trim().Equals("no"))
                    {
                        title.Text = "远程任务创建失败！";
                   //     MessageBox.Show(ret);
                    }
                    else
                    {
                        title.Text = "远程任务创建成功！"; //显示终端返回值
                        ret=Encoding.UTF8.GetString(Convert.FromBase64String(ret.Trim()));
                        String [] retList=ret.Split('~');

                        skinLabel1.Text = retList[0]; //base64 解码 显示server socket返回值 文件名
                        title.Text = retList.Length.ToString(); //文件大小
                        title.Text = retList[1];
                        fileTotalSize = retList[1];

                        //分割字符串获取 数据块总大小 并传给进度条
                        String danWei = fileTotalSize.Substring(fileTotalSize.Length - 3);
                        if (danWei == "MiB")
                        {
                            CloudFileSize = Convert.ToDouble(fileTotalSize.Substring(0, fileTotalSize.Length - 3));
                        }
                        else if (danWei == "GiB")
                        {
                            CloudFileSize = Convert.ToDouble(fileTotalSize.Substring(0, fileTotalSize.Length - 3))*1024;
                        }

                        if (CloudFileSize != 0)
                        {
                            skinProgressBar1.Maximum = (int)CloudFileSize;// 进度条转换为最大
                        }
                           


                        Thread downloadThread = new Thread(new ThreadStart(downloadProcess)); //创建下载进度进程 
                        downloadThread.Start();
                        
                        //界面变化
                        skinProgressBar1.Visible = true;
                        skinProgressBar1.Value = 0;
                        skinTextBox1.Visible = false;
                        pictureBox5.Enabled = false; //禁用 传送按钮
                        
                      //  MessageBox.Show(retList[0]);
                      
                        
                     //   MessageBox.Show(DownloadSize);

                    }

                }

            }
            else
            {
                title.Text = "链接格式错误！";
                skinTextBox1.Text = "";
            }

        }

        private  void downloadProcess() {
            //持续获取文件大小
            String DownloadSize = GetFileSize
                ("FileSizer.exe", username, password, Convert.ToBase64String(Encoding.UTF8.GetBytes(skinLabel1.Text + ".part")));

   /*         if (DownloadSize != "Finish!") //第一次就完成 则代表 已存在
            {
                title.Text = "文件已经存在！";
                skinProgressBar1.Visible = false;
                skinTextBox1.Text = "";
                skinTextBox1.Visible = true;
                skinLabel1.Text = "文件已经完成过同步任务！";
                pictureBox5.Enabled = true; //开启 传送按钮
            }
            */
            while (DownloadSize != "Finish!")
            {
                
                Thread.Sleep(1000);
                DownloadSize = GetFileSize
               ("FileSizer.exe", username, password, Convert.ToBase64String(Encoding.UTF8.GetBytes(skinLabel1.Text + ".part")));
                
                
                if (DownloadSize == "Finish!")  //必须含有这个条件
                {
                    skinProgressBar1.Value = skinProgressBar1.Maximum;

                    //界面变化
                    skinProgressBar1.Visible = false;
                    skinTextBox1.Text = "";
                    skinTextBox1.Visible = true;
                    pictureBox5.Enabled = true; //开启 传送按钮
                    title.Text = "数据同步完毕！";
                    break;
                }
                else
                {
                    skinProgressBar1.Value = (int)Convert.ToDouble(DownloadSize.ToString());
                    title.Text = DownloadSize + "MB/" + fileTotalSize;
                }
            }  
          
            //获取云端文件已经存在的判断 文件存在
            if (skinLabel1.Text =="Existed!")
            {
                skinProgressBar1.Visible = false;
                skinTextBox1.Text = "";
                skinTextBox1.Visible = true;
                title.Text = "文件已经存在！";
                pictureBox5.Enabled = true; //开启 传送按钮
                skinLabel1.Text = "文件已经完成过同步任务！";
            }
        }

        private Boolean CheckUrl(String url)
        {
            String reg = "https://www.youtube.com/watch?v=";
            if (url.Length < 43)
                return false;

            if (url[29] != '?')
                return false;

            for (int i = 0; i < 11; i++)
            {
                reg += url[i + 32];
            }

            if (reg.Equals(url))
            {
                return true;
            }
            else
                return false;
        }

        private String CreateRemoteTask(String ExeFileName, String username, String password, String base64_url) //传递base64编码链接
        {
            //创建进程 开启用户账户信息测试
            Process prc = new Process();
            prc.StartInfo.FileName = ExeFileName;

            prc.StartInfo.Arguments = username + " " + password + " " + base64_url;
            prc.StartInfo.CreateNoWindow = true;
            prc.StartInfo.UseShellExecute = false;
            prc.StartInfo.RedirectStandardOutput = true;
            // prc.Exited += new EventHandler(prc_Exited);
            prc.Start();
           // prc.WaitForExit();
            //  prc.Exited += new EventHandler(prc_Exited);
            String data = prc.StandardOutput.ReadLine();
            prc.Dispose();
            return data;

        }


        private static String GetFileSize(String ExeFileName, String username, String password, String base64_fileName) //传递base64编码链接
        {
            //创建进程 开启用户账户信息测试
            Process prc = new Process();
            prc.StartInfo.FileName = ExeFileName;

            prc.StartInfo.Arguments = username + " " + password + " " + base64_fileName;
            prc.StartInfo.CreateNoWindow = true;
            prc.StartInfo.UseShellExecute = false;
            prc.StartInfo.RedirectStandardOutput = true;
            // prc.Exited += new EventHandler(prc_Exited);
            prc.Start();
          //  prc.WaitForExit();
            //  prc.Exited += new EventHandler(prc_Exited);
            String data = prc.StandardOutput.ReadLine();
            prc.Dispose();
            return data;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }

}
