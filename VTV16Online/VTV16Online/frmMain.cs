using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using WMPLib;
namespace VTV16Online
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        HtmlWeb htmlWeb = new HtmlWeb()
        {
            AutoDetectEncoding = false,
            OverrideEncoding = Encoding.UTF8
        };
        HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
        List<HtmlNode> listTop;
        List<SaveString.Category> categories = new List<SaveString.Category>();
        public string linkFilm = "";
        public string linkIframe = "";
        public string linkNode = "";
        public string nameFilm = "";
        public string nameCategory = "HOME";
        public bool check = true;
        private void frmMain_Load(object sender, EventArgs e)
        {
            lblTitle.Text = SaveString.title;
            lblAuthor.Text = SaveString.author;

            TreeNode node = new TreeNode("HOME");
            tvCategory.Nodes.Add(node);

            loadCategory();
            loadListFilm(SaveString.url);
            
        }

        private void loadCategory()
        {
            htmlDocument = htmlWeb.Load(SaveString.url);
            //Load Category
            listTop = htmlDocument.DocumentNode.QuerySelectorAll("div#menu > ul.container > li > ul.sub >li").ToList();
            foreach (var item in listTop)
            {
                var node = item.QuerySelector("a");
                var title = node.InnerText;
                var link = node.Attributes["href"].Value;
                categories.Add(new SaveString.Category(title, link));
            }

            for(int i = 0; i < categories.Count; i++)
            {
                TreeNode node = new TreeNode(categories[i].name);
                node.Tag = categories[i].link;
                node.ImageIndex = 0;
                tvCategory.Nodes.Add(node);
            }
        }
        private void tvCategory_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            wmpPlay.Ctlcontrols.stop();
            wmpPlay.Visible = false;
            fpnlMain.Visible = true;
            fpnlMain.Controls.Clear();
            TreeNode node = e.Node;
            nameCategory = node.Text;
            if (node.Text != "HOME")
            {
                loadListFilm(node.Tag.ToString());
                linkNode = node.Tag.ToString();
            }
            else
            {
                loadListFilm(SaveString.url);
            }
            fpnlMain.AutoScroll = true;
        }

        private void loadListFilm(string url)
        {
            lblTitle.Text = SaveString.title + " - "+nameCategory;
            htmlDocument = htmlWeb.Load(url);
            var lstTops = htmlDocument.DocumentNode.QuerySelectorAll("ul.list-film > li").ToList();
            var lstFilms = new List<SaveString.Film>();
            var lstImages = new List<string>();
            var lstStatus = new List<string>();
            //Load image
            foreach (var item in lstTops)
            {
                var node = item.QuerySelector("img");
                var linkImg = node.Attributes["src"].Value;
                lstImages.Add(linkImg);
            }
            //Load film name
            foreach (var item in lstTops)
            {
                var node = item.QuerySelector("div.name > h4 > a");
                var link = node.Attributes["href"].Value;
                var title = node.InnerText;
                lstFilms.Add(new SaveString.Film(title, link));
            }
            //load status
            foreach (var item in lstTops)
            {
                var node = item.QuerySelector("div.status");
                var status = node.InnerText;
                lstStatus.Add(status);
            }
            for (int i = 0; i < lstImages.Count; i++)
            {
                Panel panel = new Panel();
                panel.Size = new Size(175, 350);
                panel.BorderStyle = BorderStyle.None;
                panel.BackColor = Color.Black;
                panel.Click += Panel_Click; //add event

                PictureBox picture = new PictureBox();
                picture.ImageLocation = lstImages[i];
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Width = 175;
                picture.Height = 275;
                picture.Dock = DockStyle.Bottom;
                picture.Click += Picture_Click; //add event

                Label name = new Label();
                name.Text = lstFilms[i].name;
                name.Font = new Font(new FontFamily("Arial"), 11, FontStyle.Regular);
                name.ForeColor = Color.White;
                name.Dock = DockStyle.Bottom;
                name.Width = 175;
                name.Height = 75;
                name.Click += Name_Click; //add event

                Label status = new Label();
                status.Text = lstStatus[i];
                status.Font = new Font(new FontFamily("Arial"), 8, FontStyle.Bold);
                status.BackColor = Color.Red;
                status.ForeColor = Color.White;
                status.Dock = DockStyle.Bottom;
                status.Width = 175;

                //add tag
                panel.Tag = lstFilms[i].link;
                picture.Tag = lstFilms[i].link;
                name.Tag = lstFilms[i].link;
                status.Tag = name.Text;

                panel.Controls.Add(picture);
                panel.Controls.Add(name);
                panel.Controls.Add(status);

                fpnlMain.Controls.Add(panel);
            }
        }
        private void Name_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            nameFilm = label.Parent.Controls[2].Tag.ToString();
            string url = label.Tag.ToString() + "/xem-phim.html";
            linkIframe = getLinkIframe(url);
            playFilm(linkIframe);
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            nameFilm = pic.Parent.Controls[2].Tag.ToString();
            string url = pic.Tag.ToString() + "/xem-phim.html";
            linkIframe = getLinkIframe(url);
            playFilm(linkIframe);
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            string url = panel.Tag.ToString() + "/xem-phim.html";
            linkIframe = getLinkIframe(url);
            playFilm(linkIframe);
        }
        private string getLinkIframe(string url)
        {
            WebClient client = new WebClient();
            String htmlCode = client.DownloadString(url);
            string link = htmlCode.Substring(htmlCode.IndexOf("urlPlay =")+11);
            link = link.Substring(0, link.IndexOf("\n")-2);
            return link;
        }

        private void playFilm(string linkIframe)
        {
            lblTitle.Text += " - Phim: " + nameFilm;
            try
            {
                WebClient client = new WebClient();
                String htmlCode = client.DownloadString(linkIframe);
                linkFilm = htmlCode.Substring(htmlCode.IndexOf("file\":\"") + 7);
                linkFilm = linkFilm.Substring(0, linkFilm.IndexOf("\"label\"") - 2);

                fpnlMain.Visible = false;
                wmpPlay.URL = linkFilm;
                wmpPlay.Ctlcontrols.play();
                wmpPlay.Visible = true;
            }
            catch
            {
                MessageBox.Show("Phim chưa sẵn sàng.");
                loadListFilm(linkNode);   
            }
            
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            if (check)
            {
                wmpPlay.Dock = DockStyle.Fill;
                pnlSide.Visible = false;
                check = !check;
            }
            else
            {
                pnlSide.Visible = true;
                check = !check;
            }
        }

        private void lblAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process process = new System.Diagnostics.Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "https://www.facebook.com/duongvansonit";
            process.StartInfo = startInfo;
            process.Start();
        }
        public bool checkHide = true;
        private void lblTitle_Click(object sender, EventArgs e)
        {
            if (checkHide)
            {
                pnlTop.Controls.Clear();
                pnlTop.Height = 10;
                pnlTop.BackColor = Color.Black;
                checkHide = false;
                Label lbl = new Label();
                lbl.Text = "v";
                lbl.Font = new Font(new FontFamily("Arial"), 8, FontStyle.Bold);
                lbl.ForeColor = Color.White;
                lbl.Dock = DockStyle.Fill;
                lbl.AutoSize = false;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Click += Lbl_Click;
                pnlTop.Controls.Add(lbl);
            }
            
        }

        private void Lbl_Click(object sender, EventArgs e)
        {
            checkHide = true;
            pnlTop.Height = 40;
            pnlTop.BackColor = Color.GhostWhite;
            pnlTop.Controls.RemoveAt(0);
            pnlTop.Controls.Add(picHome);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Controls.Add(lblAuthor);
        }
    }
}
