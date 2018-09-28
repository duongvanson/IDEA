using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTV16Online
{
    public class SaveString
    {
        public static string title = "VTV 16 ONLINE";
        public static string url = "http://www.vtv16.com";
        public static string intal = "Install-Package Fizzler.Systems.HtmlAgilityPack";
        public static string author = "by VSond";
        public class Category
        {
            public string name { get; set; }
            public string link { get; set; }
            public Category(string name, string link)
            {
                this.name = name;
                this.link = link;
            }
        }
        public class Film
        {
            public string name { get; set; }
            public string link { get; set; }
            public Film(string name, string link)
            {
                this.name = name;
                this.link = link;
            }
        }
    }
}
