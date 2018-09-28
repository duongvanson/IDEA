using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
namespace TruyenTranh
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //Biến dùng chung
        bool phongManHinh = false;
        HtmlWeb htmlWeb = new HtmlWeb()
        {
            AutoDetectEncoding = false,
            OverrideEncoding = Encoding.UTF8
        };
        HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
        //Biến dùng chung
        private void frmMain_Load(object sender, EventArgs e)
        {

            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send("64.233.181.99");
                if (reply.Status != IPStatus.Success) //Kiểm tra kết nối
                {
                    this.Controls.Clear();
                    Label thonBao = new Label
                    {
                        Text = "Kiểm tra lại kết nối mạng.",
                        ForeColor = Color.Red,
                        AutoSize = false,
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    this.Controls.Add(thonBao);
                    return;
                }
            }
            catch (Exception)
            {
                throw;
            }
            layDanhSachTheLoai();
        }
        //Lấy danh sách thể loại
        private void layDanhSachTheLoai()
        {
            try
            {
                htmlDocument = htmlWeb.Load(CauHinh.web);
                var theLoais = htmlDocument.DocumentNode.QuerySelectorAll("ul.genres-list > li").ToList();
                for (int i = 0; i < theLoais.Count; i++)
                {
                    if (i == 0) continue;
                    //Lấy thể loại
                    var theLoai = theLoais[i].QuerySelector("a");
                    var urlTheLoai = CauHinh.web + theLoai.Attributes["href"].Value;
                    var tenTheLoai = theLoais[i].InnerText;
                    //Tạo node thêm vào treview
                    TreeNode node = new TreeNode(tenTheLoai);
                    node.Tag = urlTheLoai;
                    tvTheLoai.Nodes.Add(node);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Khi người dùng chọn thể loại
        private void tvTheLoai_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (!phongManHinh)
            {
                phanChiaManNho();
                tlpnlTheLoai.Visible = true;
                tlpnlChapTruyen.Visible = false;
            }
            else
            {
                phanChiaManLon();
            }
            //Lấy danh sách truyện theo thể loại
            TreeNode node = e.Node;
            try
            {
                layDanhSachTruyen(node.Tag.ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("Thể loại bị lỗi, xin thử lại.", "Thông báo");
                throw;
            }
            //
        }
        //Lấy danh sách truyện theo thê loại
        private void layDanhSachTruyen(string urlTheLoai)
        {
            fpnlDanhSachTheoTheLoai.Controls.Clear();
            pnlPhanTrang.Controls.Clear();
            //Lấy theo div
            htmlDocument = htmlWeb.Load(urlTheLoai);
            var query = "div.manga-list > div.item";
            var truyens = htmlDocument.DocumentNode.QuerySelectorAll(query).ToList();
            //Lấy thông tin
            for (int i = 0; i < truyens.Count; i++)
            {
                var truyen = truyens[i].QuerySelector("a.img");
                var urlTruyen = CauHinh.web + truyen.Attributes["href"].Value;
                var hinh = truyen.QuerySelector("img");
                var tenTruyen = hinh.Attributes["title"].Value;
                var urlHinh = hinh.Attributes["src"].Value;
                var diem = truyens[i].QuerySelector("i").InnerText;
                //Đổ lên view
                TableLayoutPanel panel = new TableLayoutPanel()
                {
                    Width = 150,
                    Height = 300,
                    BackColor = Color.Black,
                    BorderStyle = BorderStyle.None,
                    RowCount = 3,
                    ColumnCount = 1,
                };
                panel.RowStyles.Add(new RowStyle(SizeType.Percent, 70f));
                panel.RowStyles.Add(new RowStyle(SizeType.Percent, 15f));
                panel.RowStyles.Add(new RowStyle(SizeType.Percent, 15f));
                panel.Tag = urlTruyen;
                //Hình
                PictureBox picture = new PictureBox()
                {
                    ImageLocation = urlHinh,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Fill
                };
                picture.Click += Picture_Click;
                panel.Controls.Add(picture, 0, 0);
                //Ten truyen
                Label lblTen = new Label()
                {
                    Text = tenTruyen,
                    ForeColor = Color.Blue,
                    AutoSize = false,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft
                };
                lblTen.Click += LblTen_Click;
                panel.Controls.Add(lblTen, 0, 1);
                //Diem
                Label lblDiem = new Label()
                {
                    Text = "Điểm: " + diem,
                    ForeColor = Color.White,
                    BackColor = Color.Red,
                    AutoSize = false,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                panel.Controls.Add(lblDiem, 0, 2);
                //Add view
                fpnlDanhSachTheoTheLoai.Controls.Add(panel);
            }
            //Lấy danh sách các trang
            var trangs = htmlDocument.DocumentNode.QuerySelectorAll("ul.pagination > li").ToList();
            for (int i = 0; i < trangs.Count / 2 - 1; i++)
            {
                var aTag = trangs[i].QuerySelector("a");
                var urlTrang = aTag.Attributes["href"].Value;
                Button btn = new Button()
                {
                    Text = (i + 1).ToString(),
                    Tag = urlTrang,
                    Dock = DockStyle.Right,
                    ForeColor = Color.White,
                    BackColor = Color.Black
                };
                btn.Click += Btn_Click;
                pnlPhanTrang.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Tag.ToString() != "#")
                layDanhSachTruyen(btn.Tag.ToString());
        }

        //Khi người dùng chọn chuyện
        private void taiChapTruyen(string urlTruyen)
        {
            if (!phongManHinh)
            {
                phanChiaManNho();
                tlpnlChapTruyen.Visible = true;
                tlpnlTheLoai.Visible = false;
            }
            else
            {
                phanChiaManLon();
            }
            fpnlDanhSachChap.Controls.Clear();
            htmlDocument = htmlWeb.Load(urlTruyen);
            string tomTatTruyen;
            try
            {
                //Lấy mô tả
                string query = "div.manga-summary";
                tomTatTruyen = htmlDocument.DocumentNode.QuerySelector(query).InnerText;
                //Lấy tiêu đề
                string tieuDe = htmlDocument.DocumentNode.QuerySelector("title").InnerText;
                this.Text = tieuDe;
            }
            catch (Exception)
            {
                string query = "p.tomtattruyen";
                tomTatTruyen = htmlDocument.DocumentNode.QuerySelector(query).InnerText;
            }
            rtxtMoTa.Text = tomTatTruyen;
            //Lấy danh sách chap truyện
            try
            {
                var liTag = htmlDocument.DocumentNode.QuerySelectorAll("li.u84ho3").ToList();
                for (int i = liTag.Count - 1; i >= 0; i--)
                {
                    var chap = liTag[i].QuerySelector("a");
                    var urlChap = CauHinh.web + chap.Attributes["href"].Value;
                    var tenChap = chap.InnerText;
                    var luotXem = liTag[i].QuerySelector("span.hit").InnerText;
                    var ngay = liTag[i].QuerySelector("span.date").InnerText;

                    //Tạo view chap
                    TableLayoutPanel panel = new TableLayoutPanel()
                    {
                        Width = fpnlDanhSachChap.Width,
                        Height = 35,
                    };
                    panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70f));
                    panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
                    panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
                    panel.Tag = urlChap;
                    //Ten chap
                    LinkLabel lblTenChap = new LinkLabel()
                    {
                        Text = tenChap,
                        ForeColor = Color.Green,
                        Cursor = Cursor.Current,
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleLeft,
                        AutoSize = false,
                    };
                    lblTenChap.Click += LblTenChap_Click;
                    panel.Controls.Add(lblTenChap, 0, 0);
                    //Xem
                    Label lblXem = new Label
                    {
                        Text = luotXem,
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoSize = false,
                        ForeColor = Color.Gray
                    };
                    panel.Controls.Add(lblXem, 1, 0);
                    //
                    Label lblNgay = new Label
                    {
                        Text = ngay,
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoSize = false,
                        ForeColor = Color.Gray
                    };
                    panel.Controls.Add(lblNgay, 2, 0);

                    fpnlDanhSachChap.Controls.Add(panel);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Khi người dùng chọn chap
        private void LblTenChap_Click(object sender, EventArgs e)
        {
            LinkLabel label = sender as LinkLabel;
            frmDocTruyen.urlChapTruyen = label.Parent.Tag.ToString();
            frmDocTruyen frm = new frmDocTruyen();
            frm.ShowDialog();
        }

        private void LblTen_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            taiChapTruyen(lbl.Parent.Tag.ToString());
        }
        private void Picture_Click(object sender, EventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            taiChapTruyen(picture.Parent.Tag.ToString());
        }
        //Khi phong to man hinh
        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                phongManHinh = true;
                phanChiaManLon();
            }
            else
            {
                phongManHinh = false;
                phanChiaManNho();
            }
        }
        //Phan chia man hinh
        private void phanChiaManLon()
        {
            tlpnlTheLoai.Visible = true;
            tlpnlChapTruyen.Visible = true;
            tlpnlTheLoai.Dock = DockStyle.Left;
            tlpnlChapTruyen.Dock = DockStyle.Right;
            tlpnlChapTruyen.Width = tlpnlTheLoai.Width = pnlMain.Width/2;
        }
        private void phanChiaManNho()
        {
            tlpnlTheLoai.Visible = false;
            tlpnlChapTruyen.Visible = false;
            tlpnlTheLoai.Dock = DockStyle.Fill;
            tlpnlChapTruyen.Dock = DockStyle.Fill;
        }
    }
}
