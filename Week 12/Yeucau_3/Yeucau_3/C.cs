using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeucau_3
{
    class C
    {
        public void waf()
        {
            string fileLPath = @"C:\test\test2.txt";
            string fileSPath = @"C:\test\test2.txt";

            string[] lines = new string[2];
            lines[0] = "Ghi theo dong C#.";
            lines[1] = "Dong thu 1";

            File.WriteAllLines(fileLPath, lines);

            string str;
            str = "Ghi toan bo lines";

            File.WriteAllText(fileSPath, str);
        }
    }
}
