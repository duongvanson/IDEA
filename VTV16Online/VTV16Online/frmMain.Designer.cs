namespace VTV16Online
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblAuthor = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.tvCategory = new System.Windows.Forms.TreeView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.fpnlMain = new System.Windows.Forms.FlowLayoutPanel();
            this.wmpPlay = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlTop.Controls.Add(this.lblAuthor);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.picHome);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(962, 40);
            this.pnlTop.TabIndex = 0;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAuthor.Location = new System.Drawing.Point(886, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(76, 40);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.TabStop = true;
            this.lblAuthor.Text = "linkLabel1";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAuthor_LinkClicked);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblTitle.Location = new System.Drawing.Point(40, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(922, 40);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "label1";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // picHome
            // 
            this.picHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.picHome.Image = ((System.Drawing.Image)(resources.GetObject("picHome.Image")));
            this.picHome.Location = new System.Drawing.Point(0, 0);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(40, 40);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHome.TabIndex = 0;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // pnlSide
            // 
            this.pnlSide.Controls.Add(this.tvCategory);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 40);
            this.pnlSide.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(200, 526);
            this.pnlSide.TabIndex = 1;
            // 
            // tvCategory
            // 
            this.tvCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvCategory.ImageIndex = 0;
            this.tvCategory.ImageList = this.imgList;
            this.tvCategory.Location = new System.Drawing.Point(0, 0);
            this.tvCategory.Name = "tvCategory";
            this.tvCategory.SelectedImageIndex = 0;
            this.tvCategory.Size = new System.Drawing.Size(200, 526);
            this.tvCategory.TabIndex = 0;
            this.tvCategory.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvCategory_NodeMouseClick);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "category-icon.png");
            // 
            // fpnlMain
            // 
            this.fpnlMain.BackColor = System.Drawing.Color.White;
            this.fpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlMain.Location = new System.Drawing.Point(200, 40);
            this.fpnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.fpnlMain.Name = "fpnlMain";
            this.fpnlMain.Size = new System.Drawing.Size(762, 526);
            this.fpnlMain.TabIndex = 2;
            this.fpnlMain.Tag = "play";
            // 
            // wmpPlay
            // 
            this.wmpPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wmpPlay.Enabled = true;
            this.wmpPlay.Location = new System.Drawing.Point(200, 40);
            this.wmpPlay.Name = "wmpPlay";
            this.wmpPlay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpPlay.OcxState")));
            this.wmpPlay.Size = new System.Drawing.Size(762, 526);
            this.wmpPlay.TabIndex = 0;
            this.wmpPlay.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 566);
            this.Controls.Add(this.wmpPlay);
            this.Controls.Add(this.fpnlMain);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VTV 16 ONLINE";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.pnlSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.FlowLayoutPanel fpnlMain;
        private System.Windows.Forms.TreeView tvCategory;
        private System.Windows.Forms.ImageList imgList;
        private AxWMPLib.AxWindowsMediaPlayer wmpPlay;
        private System.Windows.Forms.LinkLabel lblAuthor;
    }
}

