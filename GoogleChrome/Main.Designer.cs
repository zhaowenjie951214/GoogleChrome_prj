namespace GoogleChrome_prj
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbsetup = new System.Windows.Forms.PictureBox();
            this.pictureBoxMax = new System.Windows.Forms.PictureBox();
            this.btnReload = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsetup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.label1.Font = new System.Drawing.Font("宋体", 8F);
            this.label1.Location = new System.Drawing.Point(337, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 11);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            this.label1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pbsetup);
            this.panel1.Controls.Add(this.pictureBoxMax);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(68, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 50);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox3.Image = global::GoogleChrome.Properties.Resources.move;
            this.pictureBox3.Location = new System.Drawing.Point(199, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox3, "移动");
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            // 
            // pbsetup
            // 
            this.pbsetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.pbsetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbsetup.Image = global::GoogleChrome.Properties.Resources.setup;
            this.pbsetup.Location = new System.Drawing.Point(11, 11);
            this.pbsetup.Name = "pbsetup";
            this.pbsetup.Size = new System.Drawing.Size(28, 28);
            this.pbsetup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsetup.TabIndex = 2;
            this.pbsetup.TabStop = false;
            this.toolTip.SetToolTip(this.pbsetup, "设置服务器端口");
            this.pbsetup.Click += new System.EventHandler(this.pbsetup_Click);
            // 
            // pictureBoxMax
            // 
            this.pictureBoxMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.pictureBoxMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMax.Image = global::GoogleChrome.Properties.Resources.max;
            this.pictureBoxMax.Location = new System.Drawing.Point(122, 12);
            this.pictureBoxMax.Name = "pictureBoxMax";
            this.pictureBoxMax.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMax.TabIndex = 3;
            this.pictureBoxMax.TabStop = false;
            this.pictureBoxMax.Click += new System.EventHandler(this.pictureBoxMax_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.Location = new System.Drawing.Point(47, 11);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(28, 28);
            this.btnReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReload.TabIndex = 3;
            this.btnReload.TabStop = false;
            this.toolTip.SetToolTip(this.btnReload, "刷新");
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::GoogleChrome.Properties.Resources.min;
            this.pictureBox2.Location = new System.Drawing.Point(84, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox2, "最小化");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::GoogleChrome.Properties.Resources.close;
            this.pictureBox4.Location = new System.Drawing.Point(160, 11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox4, "退出程序");
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.pictureBox1.Image = global::GoogleChrome.Properties.Resources.wifi__1;
            this.pictureBox1.Location = new System.Drawing.Point(317, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox1, "网络状态");
            this.pictureBox1.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1360, 780);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Main";
            this.toolTip.SetToolTip(this, "移动");
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsetup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbsetup;
        private System.Windows.Forms.PictureBox btnReload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox pictureBoxMax;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}