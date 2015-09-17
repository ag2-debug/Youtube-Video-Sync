namespace Window_Client
{
    partial class Info_MsgBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info_MsgBox));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.title = new CCWin.SkinControl.SkinLabel();
            this.infotext = new CCWin.SkinControl.SkinLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinProgressBar1 = new CCWin.SkinControl.SkinProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pictureBox1.Location = new System.Drawing.Point(-11, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 162);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pictureBox2.Image = global::Window_Client.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(273, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 24);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pictureBox3.Image = global::Window_Client.Properties.Resources.Info_Error;
            this.pictureBox3.Location = new System.Drawing.Point(16, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 69);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.title.BorderColor = System.Drawing.Color.White;
            this.title.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(57, 5);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(192, 20);
            this.title.TabIndex = 3;
            this.title.Text = "skinLabel1";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // infotext
            // 
            this.infotext.AutoSize = true;
            this.infotext.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.infotext.BorderColor = System.Drawing.Color.White;
            this.infotext.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.infotext.Location = new System.Drawing.Point(105, 54);
            this.infotext.Name = "infotext";
            this.infotext.Size = new System.Drawing.Size(96, 22);
            this.infotext.TabIndex = 4;
            this.infotext.Text = "skinLabel2";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Window_Client.Properties.Resources.url;
            this.pictureBox4.Location = new System.Drawing.Point(13, 33);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(69, 70);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
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
            this.skinTextBox1.Location = new System.Drawing.Point(79, 48);
            this.skinTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox1.MaxLength = 32767;
            this.skinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox1.MouseBack = null;
            this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Multiline = true;
            this.skinTextBox1.Name = "skinTextBox1";
            this.skinTextBox1.NormlBack = null;
            this.skinTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox1.ReadOnly = false;
            this.skinTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox1.Size = new System.Drawing.Size(161, 30);
            // 
            // 
            // 
            this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox1.SkinTxt.Multiline = true;
            this.skinTextBox1.SkinTxt.Name = "BaseText";
            this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(151, 20);
            this.skinTextBox1.SkinTxt.TabIndex = 0;
            this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.SkinTxt.WaterText = "Youtube 视频网址...";
            this.skinTextBox1.TabIndex = 6;
            this.skinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox1.Visible = false;
            this.skinTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.WaterText = "Youtube 视频网址...";
            this.skinTextBox1.WordWrap = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Window_Client.Properties.Resources.send;
            this.pictureBox5.Location = new System.Drawing.Point(243, 36);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(58, 53);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.skinLabel1.Location = new System.Drawing.Point(7, 94);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(0, 17);
            this.skinLabel1.TabIndex = 8;
            // 
            // skinProgressBar1
            // 
            this.skinProgressBar1.Back = null;
            this.skinProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.skinProgressBar1.BarBack = null;
            this.skinProgressBar1.BarRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinProgressBar1.ForeColor = System.Drawing.Color.White;
            this.skinProgressBar1.Location = new System.Drawing.Point(79, 50);
            this.skinProgressBar1.Name = "skinProgressBar1";
            this.skinProgressBar1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinProgressBar1.Size = new System.Drawing.Size(160, 27);
            this.skinProgressBar1.TabIndex = 9;
            this.skinProgressBar1.Visible = false;
            // 
            // Info_MsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSize = new System.Drawing.Size(305, 114);
            this.Controls.Add(this.skinProgressBar1);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.skinTextBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.infotext);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Info_MsgBox";
            this.ShadowColor = System.Drawing.Color.Red;
            this.ShadowWidth = 10;
            this.SkinOpacity = 0.9D;
            this.Text = "";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Info_MsgBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CCWin.SkinControl.SkinLabel title;
        public CCWin.SkinControl.SkinLabel infotext;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox4;
        public CCWin.SkinControl.SkinTextBox skinTextBox1;
        public System.Windows.Forms.PictureBox pictureBox5;
        public CCWin.SkinControl.SkinLabel skinLabel1;
        public CCWin.SkinControl.SkinProgressBar skinProgressBar1;

    }
}