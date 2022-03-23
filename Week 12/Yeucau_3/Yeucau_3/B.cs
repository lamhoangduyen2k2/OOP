using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeucau_3
{
    class B
    {
        public void ReadFile()
        {
            Console.WriteLine("Doc noi dung File trong C#");
            Console.WriteLine("---------------------------------");

            try
            {
                // tao instance cua StreamReader de doc mot file.
                // lenh using cung duoc su dung de dong StreamReader
                using (StreamReader sr = new StreamReader(@"C:\test\test1.txt"))
                {
                    string line;

                    // doc va hien thi cac dong trong file cho toi
                    // khi tien toi cuoi file.
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // thong bao loi
                Console.WriteLine("Khong the doc du lieu tu file da cho");
                Console.WriteLine(e.Message);
            }
        }
    }
}
