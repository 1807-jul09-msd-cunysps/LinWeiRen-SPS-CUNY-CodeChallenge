using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromic
{
    public class PalidromicClass
    {
        public static bool Check(string s)
        {
            string p = s.Replace(" ",String.Empty).ToLower();
            string p2 =" ";
            int length = p.Length -1;
            bool result;
            for (int i = length; i >= 0; i--)
            {
                p2 += p[i];
            }
            p2 = p2.Replace(" ", String.Empty);
            if (p2 == p)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
