namespace Rule20
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblTime = new System.Windows.Forms.Label();
            this.btnStartAndStop = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.notifi = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuNotifi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mởToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dừngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pic = new System.Windows.Forms.PictureBox();
            this.menuNotifi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Green;
            this.lblTime.Location = new System.Drawing.Point(12, 179);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(360, 100);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "20 : 00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartAndStop
            // 
            this.btnStartAndStop.BackColor = System.Drawing.Color.Teal;
            this.btnStartAndStop.FlatAppearance.BorderSize = 0;
            this.btnStartAndStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartAndStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartAndStop.ForeColor = System.Drawing.Color.White;
            this.btnStartAndStop.Location = new System.Drawing.Point(122, 295);
            this.btnStartAndStop.Name = "btnStartAndStop";
            this.btnStartAndStop.Size = new System.Drawing.Size(140, 55);
            this.btnStartAndStop.TabIndex = 1;
            this.btnStartAndStop.Text = "Bắt đầu làm việc";
            this.btnStartAndStop.UseVisualStyleBackColor = false;
            this.btnStartAndStop.Click += new System.EventHandler(this.btnStartAndStop_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // notifi
            // 
            this.notifi.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifi.BalloonTipText = "Sẽ báo sau khi làm việc trong 20 phút nữa.";
            this.notifi.BalloonTipTitle = "Lời nhắc";
            this.notifi.ContextMenuStrip = this.menuNotifi;
            this.notifi.Icon = ((System.Drawing.Icon)(resources.GetObject("notifi.Icon")));
            this.notifi.Text = "Lời nhắc";
            this.notifi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifi_MouseDoubleClick);
            // 
            // menuNotifi
            // 
            this.menuNotifi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mởToolStripMenuItem,
            this.dừngToolStripMenuItem});
            this.menuNotifi.Name = "menuNotifi";
            this.menuNotifi.Size = new System.Drawing.Size(104, 48);
            // 
            // mởToolStripMenuItem
            // 
            this.mởToolStripMenuItem.Name = "mởToolStripMenuItem";
            this.mởToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.mởToolStripMenuItem.Text = "Mở";
            this.mởToolStripMenuItem.Click += new System.EventHandler(this.mởToolStripMenuItem_Click);
            // 
            // dừngToolStripMenuItem
            // 
            this.dừngToolStripMenuItem.Name = "dừngToolStripMenuItem";
            this.dừngToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.dừngToolStripMenuItem.Text = "Dừng";
            this.dừngToolStripMenuItem.Click += new System.EventHandler(this.dừngToolStripMenuItem_Click);
            // 
            // pic
            // 
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(12, 13);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(360, 150);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.btnStartAndStop);
            this.Controls.Add(this.lblTime);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VSond Rule 20-20-20";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.menuNotifi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnStartAndStop;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NotifyIcon notifi;
        private System.Windows.Forms.ContextMenuStrip menuNotifi;
        private System.Windows.Forms.ToolStripMenuItem mởToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dừngToolStripMenuItem;
    }
}

