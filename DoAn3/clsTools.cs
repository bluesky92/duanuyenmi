using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAn3
{
    public class clsTools
    {
        public static string ChuanHoa(string ch,int n)
        {
            if (ch == null) { return ""; }
            string[] h = ch.Split(new string[] { " " }, StringSplitOptions.None);
            if(h.Length<=n)
            {
                return ch;
            }
            else
            {
                ch = "";
                for(int i = 0; i < n; i++)
                {
                    ch += h[i]+" ";
                }
                return ch +"...";
            }
        }
    }
}