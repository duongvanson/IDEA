using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace StrLib
{
    public class MaHoa
    {
        //private var
        private int N = 26;
        Dictionary<int, char> tableCode26 = new Dictionary<int, char>();
        //static function
        public static string md5(string str)
        {
            var bytes = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(str));
            str = "";
            foreach (var b in bytes) str += b.ToString("x2");
            return str;
        }
        //function private
        private int layDu(int x)
        {
            if (x > 0)
            {
                x = x % N;
            }
            else
            {
                while (x < 0)
                {
                    x += N;
                }
            }
            return x;
        }

        private void loadTableCode26()
        {
            int a = 65;
            for (int i = 0; i < 26; i++)
            {
                tableCode26.Add(i, Convert.ToChar(a));
                a++;
            }
        }

    }
}
