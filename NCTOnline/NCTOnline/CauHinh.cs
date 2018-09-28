using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCTOnline
{
    public class CauHinh
    {
        public static string urlAPI = "http://congtymienbac.com.vn/nct/index.php?url=";
        public static Dictionary<string, string> danhMucs = new Dictionary<string, string>()
        {
            {"TrangChinh", "Trang Chính"},
            {"BXH", "Bảng Xếp Hạng"},
            {"Top100", "Top 100" },
            {"VietNam", "Việt Nam" },
            {"AuMy", "Âu Mỹ" },
            {"ChauA", "Châu Á" },
            {"Khac", "Khác" }
        };
        public static Dictionary<string, string> BXH = new Dictionary<string, string>()
        {
            {"BXHVietNam", "Việt Nam" },
            {"BXHAuMy", "Âu Mỹ" },
            {"BXHHanQuoc", "Hàn Quốc" }
        };
        public static Dictionary<string, string> Top100 = new Dictionary<string, string>()
        {
            {"TopVietNam", "Việt Nam" },
            {"TopAuMy", "Âu Mỹ" },
            {"TopChauA", "Châu Á" },
            {"TopKhongLoi","Không Lời" }
        };
        public static class CURL
        {
            public static string BXHVietNam = "https://www.nhaccuatui.com/bai-hat/top-20.nhac-viet.html";
            public static string BXHAuMy = "https://www.nhaccuatui.com/bai-hat/top-20.au-my.html";
            public static string BXHHanQuoc = "https://www.nhaccuatui.com/bai-hat/top-20.nhac-han.html";

            public static string TopVietNam = "https://www.nhaccuatui.com/top100/top-100-nhac-tre.m3liaiy6vVsF.html";
            public static string TopAuMy = "https://www.nhaccuatui.com/top100/top-100-pop.zE23R7bc8e9X.html";
            public static string TopChauA = "https://www.nhaccuatui.com/top100/top-100-nhac-han.iciV0mD8L9Ed.html";
            public static string TopKhongLoi = "https://www.nhaccuatui.com/top100/top-100-khong-loi.kr9KYNtkzmnA.html";

            public static string TheLoai = "https://www.nhaccuatui.com/bai-hat/bai-hat-moi.html";
        }
        public static class CString
        {
            public static string thongBao = "Thông báo";
            public static string loi = "Lỗi kết nối, vui lòng thử lại.";
        }
        //Thông tin bài hát
        public class ThongTinBaiHat
        {
            public string tenBaiHat { get; set; }
            public string tenCaSi { get; set; }
            public string urlHinh { get; set; }
            public string urlBai { get; set; }
            public ThongTinBaiHat(string tenBH, string tenCS, string hinh, string bai)
            {
                tenBaiHat = tenBH;
                tenCaSi = tenCS;
                urlBai = bai;
                urlHinh = hinh;
            }
            public ThongTinBaiHat() { }
        }
    }
}
