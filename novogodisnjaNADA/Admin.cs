using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novogodisnjaNADA
{
    public static class Admin
    {
        public static void UnosUdatoteku(string zapis)
        {
            StreamWriter sw = new StreamWriter("zivotinje.txt", true);
            sw.WriteLine(zapis);
            sw.Close();
        }
        
    }
}
