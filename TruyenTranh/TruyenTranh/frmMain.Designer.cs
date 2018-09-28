namespace TruyenTranh
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
            this.tlpnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpnlLeft = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tvTheLoai = new System.Windows.Forms.TreeView();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tlpnlTheLoai = new System.Windows.Forms.TableLayoutPanel();
            this.tlpnlChapTruyen = new System.Windows.Forms.TableLayoutPanel();
            this.fpnlDanhSachTheoTheLoai = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPhanTrang = new System.Windows.Forms.Panel();
            this.pnlMoTa = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxtMoTa = new System.Windows.Forms.RichTextBox();
            this.tlpnlThongSo = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fpnlDanhSachChap = new System.Windows.Forms.FlowLayoutPanel();
            this.tv = new System.Windows.Forms.ImageList(this.components);
            this.tlpnlMain.SuspendLayout();
            this.tlpnlLeft.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.tlpnlTheLoai.SuspendLayout();
            this.tlpnlChapTruyen.SuspendLayout();
            this.pnlMoTa.SuspendLayout();
            this.tlpnlThongSo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpnlMain
            // 
            this.tlpnlMain.ColumnCount = 2;
            this.tlpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpnlMain.Controls.Add(this.tlpnlLeft, 0, 0);
            this.tlpnlMain.Controls.Add(this.pnlMain, 1, 0);
            this.tlpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnlMain.Location = new System.Drawing.Point(0, 0);
            this.tlpnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpnlMain.Name = "tlpnlMain";
            this.tlpnlMain.RowCount = 1;
            this.tlpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlMain.Size = new System.Drawing.Size(899, 531);
            this.tlpnlMain.TabIndex = 0;
            // 
            // tlpnlLeft
            // 
            this.tlpnlLeft.ColumnCount = 1;
            this.tlpnlLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlLeft.Controls.Add(this.label1, 0, 0);
            this.tlpnlLeft.Controls.Add(this.tvTheLoai, 0, 1);
            this.tlpnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnlLeft.Location = new System.Drawing.Point(0, 0);
            this.tlpnlLeft.Margin = new System.Windows.Forms.Padding(0);
            this.tlpnlLeft.Name = "tlpnlLeft";
            this.tlpnlLeft.RowCount = 2;
            this.tlpnlLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpnlLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tlpnlLeft.Size = new System.Drawing.Size(269, 531);
            this.tlpnlLeft.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thể loại";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tvTheLoai
            // 
            this.tvTheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvTheLoai.ImageIndex = 0;
            this.tvTheLoai.ImageList = this.tv;
            this.tvTheLoai.Location = new System.Drawing.Point(0, 42);
            this.tvTheLoai.Margin = new System.Windows.Forms.Padding(0);
            this.tvTheLoai.Name = "tvTheLoai";
            this.tvTheLoai.SelectedImageIndex = 1;
            this.tvTheLoai.Size = new System.Drawing.Size(269, 489);
            this.tvTheLoai.TabIndex = 1;
            this.tvTheLoai.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvTheLoai_NodeMouseClick);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tlpnlChapTruyen);
            this.pnlMain.Controls.Add(this.tlpnlTheLoai);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(269, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(630, 531);
            this.pnlMain.TabIndex = 1;
            // 
            // tlpnlTheLoai
            // 
            this.tlpnlTheLoai.AutoScroll = true;
            this.tlpnlTheLoai.ColumnCount = 1;
            this.tlpnlTheLoai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlTheLoai.Controls.Add(this.fpnlDanhSachTheoTheLoai, 0, 0);
            this.tlpnlTheLoai.Controls.Add(this.pnlPhanTrang, 0, 1);
            this.tlpnlTheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnlTheLoai.Location = new System.Drawing.Point(0, 0);
            this.tlpnlTheLoai.Margin = new System.Windows.Forms.Padding(0);
            this.tlpnlTheLoai.Name = "tlpnlTheLoai";
            this.tlpnlTheLoai.RowCount = 2;
            this.tlpnlTheLoai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tlpnlTheLoai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpnlTheLoai.Size = new System.Drawing.Size(630, 531);
            this.tlpnlTheLoai.TabIndex = 0;
            this.tlpnlTheLoai.Visible = false;
            // 
            // tlpnlChapTruyen
            // 
            this.tlpnlChapTruyen.ColumnCount = 1;
            this.tlpnlChapTruyen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlChapTruyen.Controls.Add(this.pnlMoTa, 0, 0);
            this.tlpnlChapTruyen.Controls.Add(this.tlpnlThongSo, 0, 1);
            this.tlpnlChapTruyen.Controls.Add(this.fpnlDanhSachChap, 0, 2);
            this.tlpnlChapTruyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnlChapTruyen.Location = new System.Drawing.Point(0, 0);
            this.tlpnlChapTruyen.Margin = new System.Windows.Forms.Padding(0);
            this.tlpnlChapTruyen.Name = "tlpnlChapTruyen";
            this.tlpnlChapTruyen.RowCount = 3;
            this.tlpnlChapTruyen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tlpnlChapTruyen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.545455F));
            this.tlpnlChapTruyen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.27273F));
            this.tlpnlChapTruyen.Size = new System.Drawing.Size(630, 531);
            this.tlpnlChapTruyen.TabIndex = 1;
            this.tlpnlChapTruyen.Visible = false;
            // 
            // fpnlDanhSachTheoTheLoai
            // 
            this.fpnlDanhSachTheoTheLoai.AutoScroll = true;
            this.fpnlDanhSachTheoTheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlDanhSachTheoTheLoai.Location = new System.Drawing.Point(0, 0);
            this.fpnlDanhSachTheoTheLoai.Margin = new System.Windows.Forms.Padding(0);
            this.fpnlDanhSachTheoTheLoai.Name = "fpnlDanhSachTheoTheLoai";
            this.fpnlDanhSachTheoTheLoai.Size = new System.Drawing.Size(630, 504);
            this.fpnlDanhSachTheoTheLoai.TabIndex = 0;
            // 
            // pnlPhanTrang
            // 
            this.pnlPhanTrang.BackColor = System.Drawing.SystemColors.Control;
            this.pnlPhanTrang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPhanTrang.Location = new System.Drawing.Point(0, 504);
            this.pnlPhanTrang.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPhanTrang.Name = "pnlPhanTrang";
            this.pnlPhanTrang.Size = new System.Drawing.Size(630, 27);
            this.pnlPhanTrang.TabIndex = 1;
            // 
            // pnlMoTa
            // 
            this.pnlMoTa.Controls.Add(this.rtxtMoTa);
            this.pnlMoTa.Controls.Add(this.label2);
            this.pnlMoTa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMoTa.Location = new System.Drawing.Point(0, 0);
            this.pnlMoTa.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMoTa.Name = "pnlMoTa";
            this.pnlMoTa.Size = new System.Drawing.Size(630, 96);
            this.pnlMoTa.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 96);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mô tả";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtxtMoTa
            // 
            this.rtxtMoTa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtMoTa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtMoTa.Location = new System.Drawing.Point(58, 0);
            this.rtxtMoTa.Name = "rtxtMoTa";
            this.rtxtMoTa.Size = new System.Drawing.Size(572, 96);
            this.rtxtMoTa.TabIndex = 1;
            this.rtxtMoTa.Text = "";
            // 
            // tlpnlThongSo
            // 
            this.tlpnlThongSo.ColumnCount = 3;
            this.tlpnlThongSo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpnlThongSo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpnlThongSo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpnlThongSo.Controls.Add(this.label3, 0, 0);
            this.tlpnlThongSo.Controls.Add(this.label4, 1, 0);
            this.tlpnlThongSo.Controls.Add(this.label5, 2, 0);
            this.tlpnlThongSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnlThongSo.Location = new System.Drawing.Point(0, 96);
            this.tlpnlThongSo.Margin = new System.Windows.Forms.Padding(0);
            this.tlpnlThongSo.Name = "tlpnlThongSo";
            this.tlpnlThongSo.RowCount = 1;
            this.tlpnlThongSo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlThongSo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpnlThongSo.Size = new System.Drawing.Size(630, 24);
            this.tlpnlThongSo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(441, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên chap";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(441, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lượt xem";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(535, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fpnlDanhSachChap
            // 
            this.fpnlDanhSachChap.AutoScroll = true;
            this.fpnlDanhSachChap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlDanhSachChap.Location = new System.Drawing.Point(3, 123);
            this.fpnlDanhSachChap.Name = "fpnlDanhSachChap";
            this.fpnlDanhSachChap.Size = new System.Drawing.Size(624, 405);
            this.fpnlDanhSachChap.TabIndex = 3;
            // 
            // tv
            // 
            this.tv.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tv.ImageStream")));
            this.tv.TransparentColor = System.Drawing.Color.Transparent;
            this.tv.Images.SetKeyName(0, "categoryx24.png");
            this.tv.Images.SetKeyName(1, "indexx24.png");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 531);
            this.Controls.Add(this.tlpnlMain);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Truyện tranh - VSond";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.tlpnlMain.ResumeLayout(false);
            this.tlpnlLeft.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.tlpnlTheLoai.ResumeLayout(false);
            this.tlpnlChapTruyen.ResumeLayout(false);
            this.pnlMoTa.ResumeLayout(false);
            this.tlpnlThongSo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpnlMain;
        private System.Windows.Forms.TableLayoutPanel tlpnlLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvTheLoai;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TableLayoutPanel tlpnlTheLoai;
        private System.Windows.Forms.TableLayoutPanel tlpnlChapTruyen;
        private System.Windows.Forms.Panel pnlMoTa;
        private System.Windows.Forms.FlowLayoutPanel fpnlDanhSachTheoTheLoai;
        private System.Windows.Forms.Panel pnlPhanTrang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtMoTa;
        private System.Windows.Forms.TableLayoutPanel tlpnlThongSo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel fpnlDanhSachChap;
        private System.Windows.Forms.ImageList tv;
    }
}

