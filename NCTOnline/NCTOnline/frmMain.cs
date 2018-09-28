using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCTOnline
{
    public partial class frmMain : Form
    {
        int viTri = -1;
        Dictionary<string, string> JSON;
        bool ktTong = false; //kiem tra load thoi gian tong
        bool ktChay = false;
        int tre = 0;//do tre
        HtmlWeb htmlWeb = new HtmlWeb()
        {
            AutoDetectEncoding = false,
            OverrideEncoding = Encoding.UTF8
        };
        HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
        Random rd = new Random();
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                Ping p = new Ping();
                PingReply pr = p.Send("64.233.181.99", 3000);
                if (pr.Status == IPStatus.Success)
                {
                    taiDanhMuc();
                    ganHinhMucChinh();
                }
                else
                {
                    MessageBox.Show("Vui lòng kết nối internet!", "Thông báo");
                }
            }
            catch (Exception)
            {

                throw;
            } 
        }
        public void UpdateNow()
        {
            picHinh.ImageLocation = picHinh.ImageLocation;
        }
        private void taiDanhMuc()
        {
            foreach (KeyValuePair<string, string> item in CauHinh.danhMucs)
            {
                TreeNode node = new TreeNode(item.Value);
                node.Tag = item.Key;
                tvDanhMuc.Nodes.Add(node);
            }

            for (int i = 0; i < tvDanhMuc.Nodes.Count; i++)
            {
                TreeNode pNode = tvDanhMuc.Nodes[i];
                //Duyệt danh mục bảng xếp hạng
                if (pNode.Tag.ToString() == "BXH")
                {
                    foreach (KeyValuePair<string, string> item in CauHinh.BXH)
                    {
                        TreeNode node = new TreeNode(item.Value);
                        node.Tag = item.Key;
                        tvDanhMuc.Nodes[i].Nodes.Add(node);
                    }
                }
                //Duyệt danh mục top 100
                if (pNode.Tag.ToString() == "Top100")
                {
                    foreach (KeyValuePair<string, string> item in CauHinh.Top100)
                    {
                        TreeNode node = new TreeNode(item.Value);
                        node.Tag = item.Key;
                        tvDanhMuc.Nodes[i].Nodes.Add(node);
                    }
                    for (int j = 0; j < pNode.Nodes.Count; j++)
                    {
                        TreeNode node = tvDanhMuc.Nodes[i].Nodes[j];
                        List<HtmlNode> listNode;

                        if (node.Tag.ToString() == "TopVietNam")
                        {
                            htmlDocument = htmlWeb.Load(CauHinh.CURL.TopVietNam);
                        }
                        if (node.Tag.ToString() == "TopAuMy")
                        {
                            htmlDocument = htmlWeb.Load(CauHinh.CURL.TopAuMy);
                        }
                        if (node.Tag.ToString() == "TopChauA")
                        {
                            htmlDocument = htmlWeb.Load(CauHinh.CURL.TopChauA);
                        }
                        if (node.Tag.ToString() == "TopKhongLoi")
                        {
                            htmlDocument = htmlWeb.Load(CauHinh.CURL.TopKhongLoi);
                        }
                        listNode = htmlDocument.DocumentNode.QuerySelectorAll("ul.detail_menu_browsing_dashboard > li").ToList();
                        foreach (var item in listNode)
                        {
                            var citem = item.QuerySelector("a");
                            TreeNode cnode = new TreeNode(citem.InnerText);
                            cnode.Tag = citem.Attributes["href"].Value;
                            node.Nodes.Add(cnode);
                        }
                    }
                }
                //Lấy tất cả thể loại
                htmlDocument = htmlWeb.Load(CauHinh.CURL.TheLoai);
                List<HtmlNode> theLoais = htmlDocument.DocumentNode.QuerySelectorAll("ul.detail_menu_browsing_dashboard > li").ToList();
                //Duyệt danh mục việt nam
                if (pNode.Tag.ToString() == "VietNam")
                {
                    foreach (var item in theLoais)
                    {
                        try
                        {
                            var citem = item.QuerySelector("a");
                            string list = citem.Attributes["pr"].Value.ToString();
                            if (list == "list_vn")
                            {
                                TreeNode cNode = new TreeNode(citem.InnerText);
                                cNode.Tag = citem.Attributes["href"].Value;
                                pNode.Nodes.Add(cNode);
                            }
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }
                //Duyệt danh mục âu mỹ
                if (pNode.Tag.ToString() == "AuMy")
                {
                    foreach (var item in theLoais)
                    {
                        try
                        {
                            var citem = item.QuerySelector("a");
                            string list = citem.Attributes["pr"].Value.ToString();
                            if (list == "list_aumy")
                            {
                                TreeNode cNode = new TreeNode(citem.InnerText);
                                cNode.Tag = citem.Attributes["href"].Value;
                                pNode.Nodes.Add(cNode);
                            }
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }
                //Duyệt danh mục châu á
                if (pNode.Tag.ToString() == "ChauA")
                {
                    foreach (var item in theLoais)
                    {
                        try
                        {
                            var citem = item.QuerySelector("a");
                            string list = citem.Attributes["pr"].Value.ToString();
                            if (list == "list_chaua")
                            {
                                TreeNode cNode = new TreeNode(citem.InnerText);
                                cNode.Tag = citem.Attributes["href"].Value;
                                pNode.Nodes.Add(cNode);
                            }
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }
                //Duyệt danh mục khác
                if (pNode.Tag.ToString() == "Khac")
                {
                    foreach (var item in theLoais)
                    {
                        try
                        {
                            var citem = item.QuerySelector("a");
                            string list = citem.Attributes["pr"].Value.ToString();
                            if (list == "list_khac")
                            {
                                TreeNode cNode = new TreeNode(citem.InnerText);
                                cNode.Tag = citem.Attributes["href"].Value;
                                pNode.Nodes.Add(cNode);
                            }
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }
            }
        }
        //Tải hình ảnh danh mục chính
        private void ganHinhMucChinh()
        {
            int rj = rd.Next(7, 11);
            int rk = rd.Next(8, 11);
            for (int i = 0; i < tvDanhMuc.Nodes.Count; i++)
            {
                tvDanhMuc.Nodes[i].ImageIndex = i;
                for (int j = 0; j < tvDanhMuc.Nodes[i].Nodes.Count; j++)
                {
                    tvDanhMuc.Nodes[i].Nodes[j].ImageIndex = rj;
                    for (int k = 0; k < tvDanhMuc.Nodes[i].Nodes[j].Nodes.Count; k++)
                    {
                        tvDanhMuc.Nodes[i].Nodes[j].Nodes[k].ImageIndex = rk;
                    }
                }
            }
        }
        //Khi người dùng chọn
        private void tvDanhMuc_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            if (node.Parent != null)
            {
                fpnlMain.Controls.Clear();
                lblTrangChinh.Visible = false;
                fpnlMain.Visible = true;
                //Bảng xếp hạng
                if (node.Parent.Tag.ToString() == "BXH")
                {
                    int stt = 1;
                    List<HtmlNode> danhSachs = new List<HtmlNode>();
                    string bxh = node.Tag.ToString();
                    switch (bxh)
                    {
                        case "BXHVietNam": //Việt nam
                            try
                            {
                                htmlDocument = htmlWeb.Load(CauHinh.CURL.BXHVietNam);
                                danhSachs = htmlDocument.DocumentNode.QuerySelectorAll("ul.list_show_chart > li").ToList();
                                //Lấy khung thông tin
                                foreach (var item in danhSachs)
                                {
                                    layThongTin(stt, item, "");
                                    stt++;
                                }
                            }
                            catch
                            {
                                MessageBox.Show(CauHinh.CString.loi,
                                    CauHinh.CString.thongBao,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                            break;
                        case "BXHAuMy": //Âu mỹ
                            try
                            {
                                htmlDocument = htmlWeb.Load(CauHinh.CURL.BXHAuMy);
                                danhSachs = htmlDocument.DocumentNode.QuerySelectorAll("ul.list_show_chart > li").ToList();
                                //Lấy khung thông tin
                                foreach (var item in danhSachs)
                                {
                                    layThongTin(stt, item, "");
                                    stt++;
                                }
                            }
                            catch
                            {
                                MessageBox.Show(CauHinh.CString.loi,
                                    CauHinh.CString.thongBao,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                            break;
                        case "BXHHanQuoc": //Hàn quốc
                            try
                            {
                                htmlDocument = htmlWeb.Load(CauHinh.CURL.BXHHanQuoc);
                                danhSachs = htmlDocument.DocumentNode.QuerySelectorAll("ul.list_show_chart > li").ToList();
                                //Lấy khung thông tin
                                foreach (var item in danhSachs)
                                {
                                    layThongTin(stt, item, "");
                                    stt++;
                                }
                            }
                            catch
                            {
                                MessageBox.Show(CauHinh.CString.loi,
                                    CauHinh.CString.thongBao,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                            break;
                        default:
                            break;
                    }
                }
                //Top 100
                else if (node.Parent.Tag.ToString() == "Top100")
                {
                    int stt = 1;
                    List<HtmlNode> danhSachs;
                    string top = node.Tag.ToString();
                    switch (top)
                    {
                        case "TopVietNam": //Việt nam
                            try
                            {
                                htmlDocument = htmlWeb.Load(node.Nodes[0].Tag.ToString());
                                danhSachs = htmlDocument.DocumentNode.QuerySelectorAll("ul.list_show_chart > li").ToList();
                                //Lấy khung thông tin
                                foreach (var item in danhSachs)
                                {
                                    layThongTin(stt, item, "top100");
                                    stt++;
                                }
                            }
                            catch
                            {
                                MessageBox.Show(CauHinh.CString.loi,
                                    CauHinh.CString.thongBao,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                            break;
                        case "TopAuMy": //Âu mỹ
                            try
                            {
                                htmlDocument = htmlWeb.Load(node.Nodes[0].Tag.ToString());
                                danhSachs = htmlDocument.DocumentNode.QuerySelectorAll("ul.list_show_chart > li").ToList();
                                //Lấy khung thông tin
                                foreach (var item in danhSachs)
                                {
                                    layThongTin(stt, item, "top100");
                                    stt++;
                                }
                            }
                            catch
                            {
                                MessageBox.Show(CauHinh.CString.loi,
                                    CauHinh.CString.thongBao,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                            break;
                        case "TopChauA": //Hàn quốc
                            try
                            {
                                htmlDocument = htmlWeb.Load(node.Nodes[0].Tag.ToString());
                                danhSachs = htmlDocument.DocumentNode.QuerySelectorAll("ul.list_show_chart > li").ToList();
                                //Lấy khung thông tin
                                foreach (var item in danhSachs)
                                {
                                    layThongTin(stt, item, "top100");
                                    stt++;
                                }
                            }
                            catch
                            {
                                MessageBox.Show(CauHinh.CString.loi,
                                    CauHinh.CString.thongBao,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                            break;
                        case "TopKhongLoi": //Hàn quốc
                            try
                            {
                                htmlDocument = htmlWeb.Load(node.Nodes[0].Tag.ToString());
                                danhSachs = htmlDocument.DocumentNode.QuerySelectorAll("ul.list_show_chart > li").ToList();
                                //Lấy khung thông tin
                                foreach (var item in danhSachs)
                                {
                                    layThongTin(stt, item, "top100");
                                    stt++;
                                }
                            }
                            catch
                            {
                                MessageBox.Show(CauHinh.CString.loi,
                                    CauHinh.CString.thongBao,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                            break;
                        default:
                            break;
                    }
                }
                //Thể loại
                else if (node.Parent.Tag.ToString() == "TopVietNam" ||
                    node.Parent.Tag.ToString() == "TopAuMy" ||
                    node.Parent.Tag.ToString() == "TopChauA" ||
                    node.Parent.Tag.ToString() == "TopKhongLoi")
                {
                    int stt = 1;
                    List<HtmlNode> danhSachs;
                    try
                    {
                        htmlDocument = htmlWeb.Load(node.Tag.ToString());
                        danhSachs = htmlDocument.DocumentNode.QuerySelectorAll("ul.list_show_chart > li").ToList();
                        //Lấy khung thông tin
                        for (int i = 0; i < danhSachs.Count; i++)
                        {
                            layThongTin(stt, danhSachs[i], "top100");
                            stt++;
                        }
                    }
                    catch
                    {
                        MessageBox.Show(CauHinh.CString.loi,
                            CauHinh.CString.thongBao,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else //Danh sách theo thể loại
                {
                    int stt = 1;
                    List<HtmlNode> danhSachs;
                    try
                    {
                        htmlDocument = htmlWeb.Load(node.Tag.ToString());
                        danhSachs = htmlDocument.DocumentNode.QuerySelectorAll("ul.list_item_music > li").ToList();
                        //Lấy khung thông tin
                        foreach (var item in danhSachs)
                        {
                            layThongTinTheoTheLoai(stt, item);
                            stt++;
                        }
                    }
                    catch
                    {
                        MessageBox.Show(CauHinh.CString.loi,
                            CauHinh.CString.thongBao,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (node.Tag.ToString() == "TrangChinh")
                {
                    fpnlMain.Visible = false;
                    lblTrangChinh.Visible = true;
                }
            }
        }
        //Custom view
        private TableLayoutPanel customView(int stt, CauHinh.ThongTinBaiHat baiHat)
        {
            TableLayoutPanel panel = new TableLayoutPanel();
            panel.BackColor = Color.White;
            panel.Size = new Size(fpnlMain.Size.Width - 30, panel.Size.Height);
            panel.RowCount = 1;
            panel.ColumnCount = 3;
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35f));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));

            Label lblSTT = new Label();
            lblSTT.Text = stt.ToString();
            lblSTT.Dock = DockStyle.Fill;
            lblSTT.TextAlign = ContentAlignment.MiddleCenter;
            lblSTT.AutoSize = false;
            if (stt == 1)
            {
                lblSTT.ForeColor = Color.Red;
            }
            else if (stt == 2)
            {
                lblSTT.ForeColor = Color.Green;
            }
            else if (stt == 3)
            {
                lblSTT.ForeColor = Color.Orange;
            }
            panel.Controls.Add(lblSTT, 0, 0);

            PictureBox picture = new PictureBox();
            if (baiHat.urlHinh != null) picture.ImageLocation = baiHat.urlHinh;
            else picture.Image = NCTOnline.Properties.Resources.musicx48;
            picture.Dock = DockStyle.Fill;
            picture.SizeMode = PictureBoxSizeMode.CenterImage;
            picture.Click += Picture_Click;
            panel.Controls.Add(picture, 1, 0);

            TableLayoutPanel pnl = new TableLayoutPanel();
            pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
            pnl.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
            pnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            pnl.Dock = DockStyle.Fill;
            //
            Label lblBai = new Label
            {
                Text = baiHat.tenBaiHat,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.BottomLeft,
                AutoSize = false,
            };
            lblBai.Click += LblBai_Click;
            pnl.Controls.Add(lblBai, 0, 0);
            Label lblCaSi = new Label
            {
                Text = baiHat.tenCaSi,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.TopLeft,
                AutoSize = false,
                ForeColor = Color.Gray
            };
            lblCaSi.Click += LblCaSi_Click;
            pnl.Controls.Add(lblCaSi, 0, 1);

            panel.Controls.Add(pnl, 2, 0);
            panel.Tag = baiHat;
            panel.Click += Panel_Click;
            return panel;
        }



        //Lấy thông tin bài hát Top 100
        private void layThongTin(int stt, HtmlNode item, string what)
        {
            CauHinh.ThongTinBaiHat baiHat = new CauHinh.ThongTinBaiHat();
            var khungThongTin = item.QuerySelector("div.box_info_field");
            //Lấy thông tin chính
            var thongTin = khungThongTin.QuerySelector("a");
            baiHat.urlBai = thongTin.Attributes["href"].Value;
            //Lấy hình, tên, ca sĩ
            var hinh = thongTin.QuerySelector("img");
            if (what == "top100") baiHat.urlHinh = hinh.Attributes["data-src"].Value;
            else baiHat.urlHinh = hinh.Attributes["src"].Value;
            var arr = hinh.Attributes["title"].Value.Split('-');
            baiHat.tenBaiHat = arr[0];
            baiHat.tenCaSi = arr[1];

            TableLayoutPanel panel = customView(stt, baiHat);
            fpnlMain.Controls.Add(panel);
        }


        //Choi nhac
        private void choiNhac(CauHinh.ThongTinBaiHat baiHat)
        {
            JSON = new Dictionary<string, string>();
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string url;
            if (baiHat.urlBai.Contains("?"))
            {
                string viTri = baiHat.urlBai.Substring(baiHat.urlBai.LastIndexOf("=") + 1);
                htmlDocument = htmlWeb.Load(baiHat.urlBai);
                HtmlNode liID = htmlDocument.DocumentNode.QuerySelector("li#itemSong_" + viTri);
                var meta = liID.QuerySelectorAll("meta").ToList();
                var link = meta[1].Attributes["content"].Value;
                url = CauHinh.urlAPI + link;
            }
            else
            {
                url = CauHinh.urlAPI + baiHat.urlBai;

            }

            try
            {
                string content = client.DownloadString(url);
                content = content.Substring(content.IndexOf("{") + 1);
                content = content.Substring(0, content.IndexOf("}"));

                var arr = content.Split(',');
                foreach (string line in arr)
                {
                    string x = line.Replace("\"", "").Replace("\\", "") + "\n";
                    try
                    {
                        JSON.Add(x.Substring(0, x.IndexOf(":")), x.Substring(x.IndexOf(":") + 1));

                    }
                    catch
                    {
                        JSON.Add(x, x);
                    }
                }
                wmpMedia.URL = JSON["link128"];
                //frm.wmpMedia.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(CauHinh.CString.loi + "\n Mở bài thất bại.",
                    CauHinh.CString.thongBao,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            //Load thong tin
            picHinh.ImageLocation = baiHat.urlHinh;
            lblTenBaiHat.Text = baiHat.tenBaiHat;
            lblTenCaSi.Text = baiHat.tenCaSi;
            //Load control
            btnPlayPause.BackgroundImage = NCTOnline.Properties.Resources.pausex48;
            thoiGianChay();
            //Doi mau che do nhac
            doiMau(128);
        }

        private void doiMau(int cheDo)
        {
            if (cheDo == 128)
            {
                btn128.BackColor = Color.Black;
                btn128.ForeColor = Color.White;
                btn320.BackColor = Control.DefaultBackColor;
                btn320.ForeColor = Color.Black;
                btnLossless.BackColor = Control.DefaultBackColor;
                btnLossless.ForeColor = Color.Black;
            }
            else if (cheDo == 320)
            {
                btn320.BackColor = Color.Black;
                btn320.ForeColor = Color.White;
                btn128.BackColor = Control.DefaultBackColor;
                btn128.ForeColor = Color.Black;
                btnLossless.BackColor = Control.DefaultBackColor;
                btnLossless.ForeColor = Color.Black;
            }
            else
            {
                btnLossless.BackColor = Color.Black;
                btnLossless.ForeColor = Color.White;
                btn320.BackColor = Control.DefaultBackColor;
                btn320.ForeColor = Color.Black;
                btn128.BackColor = Control.DefaultBackColor;
                btn128.ForeColor = Color.Black;
            }
        }

        private void thoiGianChay()
        {
            timer.Enabled = true;
            ktTong = false;
            ktChay = true;
            tre = 0;
            tbChinhLoa.Maximum = 100;
            tbChinhLoa.Value = wmpMedia.settings.volume;
            //MessageBox.Show(tbThoiGian.Maximum + "");
        }
        private void Panel_Click(object sender, EventArgs e)
        {
            TableLayoutPanel panel = sender as TableLayoutPanel;
            viTri = Convert.ToInt32(panel.Controls[0].Text);
            CauHinh.ThongTinBaiHat baiHat = panel.Tag as CauHinh.ThongTinBaiHat;
            choiNhac(baiHat);
        }
        private void Picture_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            viTri = Convert.ToInt32(pic.Parent.Controls[0].Text);
            CauHinh.ThongTinBaiHat baiHat = pic.Parent.Tag as CauHinh.ThongTinBaiHat;
            choiNhac(baiHat);

        }
        private void LblCaSi_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            viTri = Convert.ToInt32(lbl.Parent.Parent.Controls[0].Text);
            CauHinh.ThongTinBaiHat baiHat = lbl.Parent.Parent.Tag as CauHinh.ThongTinBaiHat;
            choiNhac(baiHat);
        }

        private void LblBai_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            viTri = Convert.ToInt32(lbl.Parent.Parent.Controls[0].Text);
            CauHinh.ThongTinBaiHat baiHat = lbl.Parent.Parent.Tag as CauHinh.ThongTinBaiHat;
            choiNhac(baiHat);
        }

        //Lấy thông tin bài hát theo thể loại
        private void layThongTinTheoTheLoai(int stt, HtmlNode item)
        {
            CauHinh.ThongTinBaiHat baiHat = new CauHinh.ThongTinBaiHat();
            var khungThongTin = item.QuerySelector("div.item_content");
            HtmlNode main;
            //Lấy thông tin chính
            main = khungThongTin.QuerySelector("h2");
            if (main == null) main = khungThongTin.QuerySelector("h3");
            var thongTin = main.QuerySelectorAll("a").ToList();
            for (int i = 0; i < thongTin.Count; i++)
            {
                if (i == 0)
                {
                    baiHat.urlBai = thongTin[i].Attributes["href"].Value;
                    baiHat.tenBaiHat = thongTin[i].InnerText;
                    continue;
                }
                if (thongTin.Count == 2)
                {
                    baiHat.tenCaSi += thongTin[i].InnerText;
                    continue;
                }
                else
                {
                    if (i == thongTin.Count)
                    {
                        baiHat.tenCaSi += thongTin[i].InnerText;
                    }
                    else baiHat.tenCaSi += thongTin[i].InnerText + ",";
                }
            }
            //Lấy hình, tên, ca sĩ
            baiHat.urlHinh = null;
            TableLayoutPanel panel = customView(stt, baiHat);
            panel.Tag = baiHat;
            fpnlMain.Controls.Add(panel);
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (viTri == -1)
            {
                return;
            }
            if (ktChay == true)
            {
                btnPlayPause.BackgroundImage = NCTOnline.Properties.Resources.playx48;
                wmpMedia.Ctlcontrols.pause();
                ktChay = false;
            }
            else
            {
                ktChay = true;
                btnPlayPause.BackgroundImage = NCTOnline.Properties.Resources.pausex48;
                wmpMedia.Ctlcontrols.play();
            }
        }



        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!ktTong)
                {
                    ktTong = true;
                    tre += 1;
                }
                if (tre >= 1)
                {
                    lblTGTong.Text = wmpMedia.currentMedia.durationString;
                    tbThoiGian.Maximum = (int)wmpMedia.currentMedia.duration;
                    lblTGChay.Text = wmpMedia.Ctlcontrols.currentPositionString;
                    tbThoiGian.Value = (int)wmpMedia.Ctlcontrols.currentPosition;
                }
                if (tbThoiGian.Maximum > 0)
                {
                    if (wmpMedia.playState != WMPLib.WMPPlayState.wmppsPlaying && wmpMedia.playState != WMPLib.WMPPlayState.wmppsPaused)
                    {
                        btnPlayPause.BackgroundImage = NCTOnline.Properties.Resources.playx48;
                        btnNext.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(CauHinh.CString.thongBao, CauHinh.CString.loi);
            }

        }

        private void tbThoiGian_Scroll(object sender, EventArgs e)
        {
            wmpMedia.Ctlcontrols.currentPosition = tbThoiGian.Value;
        }
        private void btn128_Click(object sender, EventArgs e)
        {
            if (viTri == -1) return;
            wmpMedia.URL = JSON["link320"];
            doiMau(128);
        }
        private void btn320_Click(object sender, EventArgs e)
        {
            if (viTri == -1) return;
            wmpMedia.URL = JSON["link320"];
            doiMau(320);
        }

        private void btnLossless_Click(object sender, EventArgs e)
        {
            if (viTri == -1) return;
            wmpMedia.URL = JSON["linklossless"];
            doiMau(0);
        }

        private void tbChinhLoa_Scroll(object sender, EventArgs e)
        {
            wmpMedia.settings.volume = tbChinhLoa.Value;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (viTri == -1)
            {
                return;
            }
            if (viTri <= fpnlMain.Controls.Count - 1)
            {
                TableLayoutPanel panel = fpnlMain.Controls[viTri] as TableLayoutPanel;
                Panel_Click(panel, EventArgs.Empty);
            }
            else
            {
                TableLayoutPanel panel = fpnlMain.Controls[0] as TableLayoutPanel;
                Panel_Click(panel, EventArgs.Empty);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (viTri == -1)
            {
                return;
            }
            if (viTri > 1)
            {
                TableLayoutPanel panel = fpnlMain.Controls[viTri - 2] as TableLayoutPanel;
                Panel_Click(panel, EventArgs.Empty);
            }
            else
            {
                TableLayoutPanel panel = fpnlMain.Controls[fpnlMain.Controls.Count - 1] as TableLayoutPanel;
                Panel_Click(panel, EventArgs.Empty);
            }
        }

        
    }
}
