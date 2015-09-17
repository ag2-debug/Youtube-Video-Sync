using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;

namespace Window_Client
{
    public partial class Main_Panel : Skin_Mac
    {
        public  String username = "";
        public  String password = "";
        public Main_Panel()
        {
            InitializeComponent();
        }


        private void Main_Panel_Load(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(38,38,38);
            pictureBox3.BackColor = Color.FromArgb(38, 38, 38);
            pictureBox4.BackColor = Color.FromArgb(38, 38, 38);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void UpLink_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = Window_Client.Properties.Resources.link;
          //  pictureBox3.BackColor = Color.FromArgb(38, 38, 38);
        }

        private void UpLink_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Window_Client.Properties.Resources.link2;
        }

        private void Play_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.Image = Window_Client.Properties.Resources.media;
        }

        private void Play_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Window_Client.Properties.Resources.media2;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SendUrl("Youtube 视频链接", "ok");
            this.Hide();
        }

        //显示操作窗口
        private void SendUrl(String titleText, String showInfo)
        {
            Info_MsgBox msgbox = new Info_MsgBox();
           // msgbox.x = this.Location.X + 100;
          //  msgbox.y = this.Location.Y - 130;
            msgbox.title.Text = titleText;
            msgbox.infotext.Text = showInfo;
            msgbox.pictureBox3.Visible = false;
            msgbox.infotext.Visible = false;
            msgbox.pictureBox1.BackColor = Color.FromArgb(23, 23, 23);
            msgbox.pictureBox2.BackColor = Color.FromArgb(23, 23, 23);
            msgbox.pictureBox4.BackColor = Color.FromArgb(23, 23, 23);
            msgbox.title.BackColor = Color.FromArgb(23, 23, 23);
            msgbox.pictureBox4.Visible = true;
            msgbox.skinTextBox1.BackColor = Color.FromArgb(23, 23, 23);
            msgbox.skinTextBox1.Visible = true;
            msgbox.pictureBox5.BackColor = Color.FromArgb(23, 23, 23);
            msgbox.pictureBox5.Visible = true;
            msgbox.skinLabel1.BackColor = Color.FromArgb(23, 23, 23);
            msgbox.skinLabel1.BorderColor = Color.FromArgb(23, 23, 23);
            Window_Client.Info_MsgBox.username = username;
            Window_Client.Info_MsgBox.password = password;
            msgbox.skinProgressBar1.BackColor = Color.FromArgb(23, 23, 23);
            msgbox.skinProgressBar1.TrackBack = Color.FromArgb(23, 23, 23);
            msgbox.skinProgressBar1.Border = Color.FromArgb(23, 23, 23);
            msgbox.Disposed += new EventHandler(msgbox_Disposed);
            msgbox.Show();
        }

        void msgbox_Disposed(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
           // MessageBox.Show("close");
            this.Show();
        }



        private void pictureBox4_Click(object sender, EventArgs e)
        {
            VideoPlayer Player = new VideoPlayer();
            Player.username = username;
            Player.password = password;
            this.Hide();
            Player.Disposed += new EventHandler(Player_Disposed);
            Player.Show();

        }

        void Player_Disposed(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
