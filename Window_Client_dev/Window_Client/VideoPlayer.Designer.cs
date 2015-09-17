namespace Window_Client
{
    partial class VideoPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPlayer));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.skinComboBox1 = new CCWin.SkinControl.SkinComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loading = new System.Windows.Forms.PictureBox();
            this.fullScreen = new System.Windows.Forms.PictureBox();
            this.axPlayer1 = new AxAPlayer3Lib.AxPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = global::Window_Client.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(934, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 24);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // skinComboBox1
            // 
            this.skinComboBox1.BackColor = System.Drawing.Color.Black;
            this.skinComboBox1.BaseColor = System.Drawing.Color.DarkOrange;
            this.skinComboBox1.BorderColor = System.Drawing.Color.Black;
            this.skinComboBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox1.DropBackColor = System.Drawing.Color.Transparent;
            this.skinComboBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinComboBox1.ForeColor = System.Drawing.Color.White;
            this.skinComboBox1.FormattingEnabled = true;
            this.skinComboBox1.Location = new System.Drawing.Point(172, 8);
            this.skinComboBox1.Name = "skinComboBox1";
            this.skinComboBox1.Size = new System.Drawing.Size(584, 27);
            this.skinComboBox1.Sorted = true;
            this.skinComboBox1.TabIndex = 4;
            this.skinComboBox1.Text = "Cloud Video List";
            this.skinComboBox1.WaterText = "";
            this.skinComboBox1.SelectedIndexChanged += new System.EventHandler(this.skinComboBox1_SelectedIndexChanged);
            this.skinComboBox1.SelectedValueChanged += new System.EventHandler(this.Combox_Change);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-13, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1009, 603);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // loading
            // 
            this.loading.BackColor = System.Drawing.Color.Black;
            this.loading.Image = global::Window_Client.Properties.Resources.loading;
            this.loading.Location = new System.Drawing.Point(465, 254);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(77, 72);
            this.loading.TabIndex = 7;
            this.loading.TabStop = false;
            this.loading.Visible = false;
            // 
            // fullScreen
            // 
            this.fullScreen.BackColor = System.Drawing.Color.Black;
            this.fullScreen.Image = global::Window_Client.Properties.Resources.fullScreen;
            this.fullScreen.Location = new System.Drawing.Point(920, 486);
            this.fullScreen.Name = "fullScreen";
            this.fullScreen.Size = new System.Drawing.Size(39, 34);
            this.fullScreen.TabIndex = 8;
            this.fullScreen.TabStop = false;
            this.fullScreen.Visible = false;
            this.fullScreen.Click += new System.EventHandler(this.fullScreen_Click);
            // 
            // axPlayer1
            // 
            this.axPlayer1.Enabled = true;
            this.axPlayer1.Location = new System.Drawing.Point(29, 47);
            this.axPlayer1.Name = "axPlayer1";
            this.axPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPlayer1.OcxState")));
            this.axPlayer1.Size = new System.Drawing.Size(930, 473);
            this.axPlayer1.TabIndex = 5;
            this.axPlayer1.OnMessage += new AxAPlayer3Lib._IPlayerEvents_OnMessageEventHandler(this.axPlayer1_OnMessage);
            // 
            // VideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CanResize = false;
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientSize = new System.Drawing.Size(987, 561);
            this.Controls.Add(this.fullScreen);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.axPlayer1);
            this.Controls.Add(this.skinComboBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideoPlayer";
            this.SkinOpacity = 0.97D;
            this.Text = "视频播放器";
            this.Load += new System.EventHandler(this.VideoPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox2;
        private CCWin.SkinControl.SkinComboBox skinComboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox loading;
        private System.Windows.Forms.PictureBox fullScreen;
        public AxAPlayer3Lib.AxPlayer axPlayer1;
     //   private AxAPlayer3Lib.AxPlayer axPlayer1;
    }
}