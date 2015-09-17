namespace Window_Client
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox3 = new CCWin.SkinControl.SkinTextBox();
            this.skinTextBox2 = new CCWin.SkinControl.SkinTextBox();
            this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.skinGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::Window_Client.Properties.Resources.background;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-35, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = global::Window_Client.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(377, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.Close_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = global::Window_Client.Properties.Resources.login;
            this.pictureBox3.Location = new System.Drawing.Point(8, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 34);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Black;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.GreenYellow;
            this.skinGroupBox1.Controls.Add(this.pictureBox5);
            this.skinGroupBox1.Controls.Add(this.pictureBox4);
            this.skinGroupBox1.Controls.Add(this.skinLabel3);
            this.skinGroupBox1.Controls.Add(this.skinTextBox3);
            this.skinGroupBox1.Controls.Add(this.skinTextBox2);
            this.skinGroupBox1.Controls.Add(this.skinTextBox1);
            this.skinGroupBox1.Controls.Add(this.skinLabel2);
            this.skinGroupBox1.Controls.Add(this.skinLabel1);
            this.skinGroupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Silver;
            this.skinGroupBox1.Location = new System.Drawing.Point(48, 47);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.Black;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(317, 175);
            this.skinGroupBox1.TabIndex = 3;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "Login Panel";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.Chartreuse;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.Black;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Window_Client.Properties.Resources._return;
            this.pictureBox5.Location = new System.Drawing.Point(266, 131);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 38);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Window_Client.Properties.Resources.login_check;
            this.pictureBox4.Location = new System.Drawing.Point(122, 95);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 64);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.Transparent;
            this.skinLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.skinLabel3.Location = new System.Drawing.Point(229, 33);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(74, 20);
            this.skinLabel3.TabIndex = 6;
            this.skinLabel3.Text = "Port Num";
            this.skinLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skinTextBox3
            // 
            this.skinTextBox3.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox3.DownBack = null;
            this.skinTextBox3.Icon = null;
            this.skinTextBox3.IconIsButton = false;
            this.skinTextBox3.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox3.IsPasswordChat = '\0';
            this.skinTextBox3.IsSystemPasswordChar = false;
            this.skinTextBox3.Lines = new string[0];
            this.skinTextBox3.Location = new System.Drawing.Point(226, 54);
            this.skinTextBox3.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox3.MaxLength = 32767;
            this.skinTextBox3.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox3.MouseBack = null;
            this.skinTextBox3.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox3.Multiline = false;
            this.skinTextBox3.Name = "skinTextBox3";
            this.skinTextBox3.NormlBack = null;
            this.skinTextBox3.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox3.ReadOnly = false;
            this.skinTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox3.Size = new System.Drawing.Size(81, 28);
            // 
            // 
            // 
            this.skinTextBox3.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox3.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox3.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox3.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox3.SkinTxt.Name = "BaseText";
            this.skinTextBox3.SkinTxt.Size = new System.Drawing.Size(71, 18);
            this.skinTextBox3.SkinTxt.TabIndex = 0;
            this.skinTextBox3.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBox3.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox3.SkinTxt.WaterText = "端口号...";
            this.skinTextBox3.TabIndex = 5;
            this.skinTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBox3.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox3.WaterText = "端口号...";
            this.skinTextBox3.WordWrap = true;
            // 
            // skinTextBox2
            // 
            this.skinTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox2.DownBack = null;
            this.skinTextBox2.Icon = null;
            this.skinTextBox2.IconIsButton = false;
            this.skinTextBox2.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox2.IsPasswordChat = '●';
            this.skinTextBox2.IsSystemPasswordChar = true;
            this.skinTextBox2.Lines = new string[0];
            this.skinTextBox2.Location = new System.Drawing.Point(122, 54);
            this.skinTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox2.MaxLength = 32767;
            this.skinTextBox2.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox2.MouseBack = null;
            this.skinTextBox2.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox2.Multiline = false;
            this.skinTextBox2.Name = "skinTextBox2";
            this.skinTextBox2.NormlBack = null;
            this.skinTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox2.ReadOnly = false;
            this.skinTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox2.Size = new System.Drawing.Size(92, 28);
            // 
            // 
            // 
            this.skinTextBox2.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox2.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox2.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox2.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox2.SkinTxt.Name = "BaseText";
            this.skinTextBox2.SkinTxt.PasswordChar = '●';
            this.skinTextBox2.SkinTxt.Size = new System.Drawing.Size(82, 18);
            this.skinTextBox2.SkinTxt.TabIndex = 0;
            this.skinTextBox2.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBox2.SkinTxt.UseSystemPasswordChar = true;
            this.skinTextBox2.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox2.SkinTxt.WaterText = "登录密码...";
            this.skinTextBox2.TabIndex = 4;
            this.skinTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBox2.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox2.WaterText = "登录密码...";
            this.skinTextBox2.WordWrap = true;
            // 
            // skinTextBox1
            // 
            this.skinTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox1.DownBack = null;
            this.skinTextBox1.Icon = null;
            this.skinTextBox1.IconIsButton = false;
            this.skinTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.IsPasswordChat = '\0';
            this.skinTextBox1.IsSystemPasswordChar = false;
            this.skinTextBox1.Lines = new string[0];
            this.skinTextBox1.Location = new System.Drawing.Point(16, 54);
            this.skinTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox1.MaxLength = 32767;
            this.skinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox1.MouseBack = null;
            this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Multiline = false;
            this.skinTextBox1.Name = "skinTextBox1";
            this.skinTextBox1.NormlBack = null;
            this.skinTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox1.ReadOnly = false;
            this.skinTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox1.Size = new System.Drawing.Size(92, 28);
            // 
            // 
            // 
            this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox1.SkinTxt.Name = "BaseText";
            this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(82, 18);
            this.skinTextBox1.SkinTxt.TabIndex = 0;
            this.skinTextBox1.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.SkinTxt.WaterText = "用户名...";
            this.skinTextBox1.TabIndex = 3;
            this.skinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.WaterText = "用户名...";
            this.skinTextBox1.WordWrap = true;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.Transparent;
            this.skinLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.skinLabel2.Location = new System.Drawing.Point(134, 33);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(72, 20);
            this.skinLabel2.TabIndex = 2;
            this.skinLabel2.Text = "Password";
            this.skinLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.Transparent;
            this.skinLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.skinLabel1.Location = new System.Drawing.Point(26, 33);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(76, 20);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "Username";
            this.skinLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CanResize = false;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSize = new System.Drawing.Size(417, 265);
            this.Controls.Add(this.skinGroupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShadowColor = System.Drawing.Color.Cyan;
            this.ShadowWidth = 15;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.SkinOpacity = 0.9D;
            this.Text = "Youtube Sync Client Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTextBox skinTextBox2;
        private CCWin.SkinControl.SkinTextBox skinTextBox1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinTextBox skinTextBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;


    }
}

