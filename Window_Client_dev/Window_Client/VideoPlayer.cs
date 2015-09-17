using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
using System.Diagnostics;
using System.Web;


namespace Window_Client
{
    public partial class VideoPlayer : Skin_Mac
    {
        public  String username;
        public String password;
        public VideoPlayer()
        {
            InitializeComponent();
        }

        private String selectName="";


        private void VideoPlayer_Load(object sender, EventArgs e)
        {
            axPlayer1.SetCustomLogo(-1); //去除播放器Logo图案
            String VideoList = GeVideoList("VideoLister.exe", username, password);
            VideoList=VideoList.Trim();
            if (VideoList == "no" || VideoList == "Link Error") // no: 安全验证失败 Link Error：Socket网络连接失败
            {
               // MessageBox.Show(username+"  "+password);
                skinComboBox1.Text = "错误：服务器连接失败！";
            }
            else if (VideoList == "null")
            {
                skinComboBox1.Text = "提示：暂无可以观看的视频!";

            }
            else
            {
                //分割数据 数据格式为 base64 base64 base64...
                String[] base64_VideoName = VideoList.Split('\n');
                //MessageBox.Show(base64_VideoName.Length.ToString());
                for (int i = 0; i < base64_VideoName.Length; i++)
                {
                    String fileName = Encoding.UTF8.GetString(Convert.FromBase64String(base64_VideoName[i]));
                    skinComboBox1.Items.Add(fileName.Substring(0,fileName.Length-4));
                  //  MessageBox.Show(fileName);
                }
            }
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            axPlayer1.Close();
            axPlayer1.Dispose();
            this.Dispose();
        }


        private String GeVideoList(String ExeFileName,String username,String password)
        {
            //创建进程 开启用户账户信息测试
            Process prc = new Process();
            prc.StartInfo.FileName = ExeFileName;
            prc.StartInfo.Arguments = username + " " + password;
            prc.StartInfo.CreateNoWindow = true;
            prc.StartInfo.UseShellExecute = false;
            prc.StartInfo.RedirectStandardOutput = true;
            // prc.Exited += new EventHandler(prc_Exited);
            prc.Start();
           // prc.WaitForExit();
            //  prc.Exited += new EventHandler(prc_Exited);
            String data = prc.StandardOutput.ReadToEnd();
            prc.Dispose();
            return data;

        }

        private void Combox_Change(object sender, EventArgs e)
        {
            if (!selectName.Equals(skinComboBox1.Text))
            {
                selectName = skinComboBox1.Text;
               // MessageBox.Show(slectName);

                axPlayer1.Visible = false; //关闭屏幕
                 loading.Visible = true;  //开启等待效果
                 fullScreen.Visible = false;
                playVideo("http://video.icorer.com/libiao/", selectName, ".mp4");
            }
                
        }

        private void playVideo(String baseUrl,String fileName,String formate) {
            String url = baseUrl + Uri.EscapeUriString(fileName) + formate;
          //  axPlayer1.OnBuffer += new AxAPlayer3Lib._IPlayerEvents_OnBufferEventHandler(axPlayer1_OnBuffer);
             axPlayer1.Open(url);
             axPlayer1.OnOpenSucceeded += new EventHandler(axPlayer1_OnOpenSucceeded);
                
        }

        void axPlayer1_OnOpenSucceeded(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            loading.Visible = false; //关闭等待效果
            axPlayer1.Visible = true;
            fullScreen.Visible = true;
            axPlayer1.Play();
           
          //  MessageBox.Show("ok");
        }

        private void skinComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void axPlayer1_OnMessage(object sender, AxAPlayer3Lib._IPlayerEvents_OnMessageEvent e)
        {

        }

        private void fullScreen_Click(object sender, EventArgs e)
        {
           
        }





    }
}
