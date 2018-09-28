using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruyenTranh
{
    public partial class frmDocTruyen : Form
    {
        public frmDocTruyen()
        {
            InitializeComponent();
        }
        public static string urlChapTruyen = "";
        private void frmDocTruyen_Load(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            string soucre = wc.DownloadString(urlChapTruyen);
            try
            {
                string tieuDe = soucre.Substring(soucre.IndexOf("<title>")+7);
                tieuDe = tieuDe.Substring(0, tieuDe.IndexOf("</title>"));
                this.Text = tieuDe;
            }
            catch (Exception)
            {
            }
            soucre = soucre.Substring(soucre.IndexOf("<img class=\"\""));
            soucre = soucre.Substring(0, soucre.IndexOf("</textarea>")).Trim();
            var list = soucre.Split('>');
            for (int i = 0; i < list.Length; i++)
            {
                try
                {
                    var img = list[i].Substring(list[i].IndexOf("http"));
                    img = img.Substring(0, img.IndexOf("title") - 2);
                    //Đẩy lên hình
                    PictureBox picture = new PictureBox()
                    {
                        ImageLocation = img,
                        SizeMode = PictureBoxSizeMode.AutoSize,
                    };
                    picture.Tag = i;
                    picture.SizeChanged += Picture_SizeChanged;
                    fpnlMain.Controls.Add(picture);
                }
                catch (Exception)
                {
                }
            }
            this.Top = 0;
            this.Height = 1000;
        }

        private void Picture_SizeChanged(object sender, EventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            if (picture.Tag.ToString() == "2")
            {
                this.Width = picture.Width;
            }
        }
    }
}
