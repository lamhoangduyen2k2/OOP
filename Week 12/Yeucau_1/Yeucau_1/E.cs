using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeucau_1
{
    class E
    {
        string filePath = "C:/test/test.txt";
        public void ktFile()
        {
            // Kiểm tra đường dẫn này có tồn tại hay không?
            if (File.Exists(filePath))
            {
                // Xóa file
                File.Delete(filePath);

                // Kiểm tra lại xem file còn tồn tại không.
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File deleted...");
                }
            }
            else
            {
                Console.WriteLine("File test.txt does not yet exist!");
            }
            Console.ReadKey();
        }
    }
}
