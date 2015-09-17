using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
using System.Threading;
using System.Diagnostics;

namespace Window_Client
{
    public partial class Form1 : Skin_Mac
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null; //清空图片素材
            pictureBox3.Visible = false;
            skinGroupBox1.Visible = true;
            skinGroupBox1.Size = new Size(0, 0);
            Thread effectThread = new Thread(new ThreadStart(LoginEffectThread));
            effectThread.Start(); //登录界面动画效果
            
        }

        private void LoginEffectThread() {
            for (int i = 0; i <= 317; i++)
            {
                skinGroupBox1.Size = new Size(i,0);
                
            }
            for (int i = 0; i <= 175; i++)
            {
                skinGroupBox1.Size = new Size(317, i);
            }
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Window_Client.Properties.Resources.background;
            skinGroupBox1.Visible = false;
            pictureBox3.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (skinTextBox1.Text != "" && skinTextBox2.Text != "" && skinTextBox3.Text != "")
            {
                 
                if (IsNum(skinTextBox3.Text)) //检测端口的数字符合度
                {
                    pictureBox4.Image = Window_Client.Properties.Resources.loading;
                    String Ret=CheckUser("UserLoginCheck");
                    /*
                      Ret ：no yes  Link Error
                     */
                    pictureBox4.Image = Window_Client.Properties.Resources.login_check;
                    if (Ret.Trim().Equals("Link Error"))
                        Info_MessageBox("登录信息提示", "无法连接验证服务器！");
                    else if (Ret.Trim().Equals("no"))
                        Info_MessageBox("登录信息提示", "用户登录信息错误！");
                    else
                    { 
                        //登录成功
                        this.Hide();
                        Main_Panel mainControlPanel = new Main_Panel();
                        mainControlPanel.username = skinTextBox1.Text.Trim(); //传递用户名数据
                        mainControlPanel.password = skinTextBox2.Text.Trim(); //传递密码数据
                        mainControlPanel.Show();
                    }

                }
                else
                {
                    Info_MessageBox("登录信息提示", "请正确填写服务器端口！");
                }
                
            }
            else
            {
                Info_MessageBox("登录信息提示", "请填写完整的登录信息！");
            }

        }
        private void Info_MessageBox(String titleText,String showInfo)
        {
            Info_MsgBox msgbox = new Info_MsgBox();
            msgbox.x = this.Location.X + 53;
            msgbox.y = this.Location.Y - 130;
            msgbox.title.Text = titleText;
            msgbox.infotext.Text = showInfo;
            msgbox.ShowDialog();
        }

        private Boolean IsNum(String text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= '0' && text[i] <= '9')
                    continue;
                else
                    return false;
            }
            return true;
        }

        private String CheckUser(String ExeFileName)
        {
            //创建进程 开启用户账户信息测试
            Process prc = new Process();
            prc.StartInfo.FileName = ExeFileName;
            prc.StartInfo.Arguments = skinTextBox1.Text + " " + skinTextBox2.Text + " " + skinTextBox3.Text;
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



    }
}
