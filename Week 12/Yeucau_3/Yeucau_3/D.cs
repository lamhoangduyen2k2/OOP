using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeucau_3
{
    class D
    {
        public void write()
        {
            Console.WriteLine("\n Vi du minh hoa doc va ghi File trong C#");
            Console.WriteLine("---------------------------------");

            string[] names = new string[] { "Boss", "Hourly Worker", "Commission Workers", "Part Time" };
            StreamWriter sw = new StreamWriter(@"C:\test\test1.txt");

            foreach (string s in names)
            {
                sw.WriteLine(s);
            }
            sw.Close();

            // doc va hien thi du lieu trong textfile.txt
            string line = "";
            StreamReader sr = new StreamReader(@"C:\test\test1.txt");

            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
