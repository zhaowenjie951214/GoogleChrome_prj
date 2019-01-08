namespace GoogleChrome_prj
{
    partial class MainA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainA));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbsetup = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnReload = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lalTiile = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxMax = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsetup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::GoogleChrome.Properties.Resources.登录页插图;
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox1, "设置服务器端口");
            // 
            // pbsetup
            // 
            this.pbsetup.BackColor = System.Drawing.Color.Transparent;
            this.pbsetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbsetup.Image = global::GoogleChrome.Properties.Resources.setup;
            this.pbsetup.Location = new System.Drawing.Point(28, 4);
            this.pbsetup.Name = "pbsetup";
            this.pbsetup.Size = new System.Drawing.Size(28, 28);
            this.pbsetup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsetup.TabIndex = 2;
            this.pbsetup.TabStop = false;
            this.toolTip.SetToolTip(this.pbsetup, "设置服务器端口");
            this.pbsetup.Click += new System.EventHandler(this.pbsetup_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::GoogleChrome.Properties.Resources.close;
            this.pictureBox4.Location = new System.Drawing.Point(177, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox4, "退出程序");
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::GoogleChrome.Properties.Resources.min;
            this.pictureBox2.Location = new System.Drawing.Point(101, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox2, "最小化");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.Location = new System.Drawing.Point(64, 4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(28, 28);
            this.btnReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReload.TabIndex = 3;
            this.btnReload.TabStop = false;
            this.toolTip.SetToolTip(this.btnReload, "刷新");
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(150)))), ((int)(((byte)(219)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lalTiile);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1358, 37);
            this.panel2.TabIndex = 5;
            this.panel2.DoubleClick += new System.EventHandler(this.panel2_DoubleClick);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // lalTiile
            // 
            this.lalTiile.AutoSize = true;
            this.lalTiile.Location = new System.Drawing.Point(33, 13);
            this.lalTiile.Name = "lalTiile";
            this.lalTiile.Size = new System.Drawing.Size(47, 12);
            this.lalTiile.TabIndex = 6;
            this.lalTiile.Text = "晶创MES";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbsetup);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBoxMax);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1148, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 37);
            this.panel1.TabIndex = 5;
            // 
            // pictureBoxMax
            // 
            this.pictureBoxMax.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMax.Image = global::GoogleChrome.Properties.Resources.max;
            this.pictureBoxMax.Location = new System.Drawing.Point(139, 5);
            this.pictureBoxMax.Name = "pictureBoxMax";
            this.pictureBoxMax.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMax.TabIndex = 3;
            this.pictureBoxMax.TabStop = false;
            this.pictureBoxMax.Click += new System.EventHandler(this.pictureBoxMax_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(1, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1358, 741);
            this.panel3.TabIndex = 6;
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // MainA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1360, 780);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainA";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Main";
            this.toolTip.SetToolTip(this, "移动");
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsetup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbsetup;
        private System.Windows.Forms.PictureBox btnReload;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox pictureBoxMax;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lalTiile;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}