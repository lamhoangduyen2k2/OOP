using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeucau_1
{
    class D
    {
        FileInfo testFile = new FileInfo("C:/test/test.txt");
        public void infoFile()
        {
            if (testFile.Exists)
            {
                Console.WriteLine(testFile.FullName + " exist.");
                // Thông tin thời điểm tạo file.
                Console.WriteLine("Creation time: " + testFile.CreationTime);

                // Thông tin thời điểm file được sửa đổi lần cuối.
                Console.WriteLine("Last Write Time " + testFile.LastWriteTime);

                // Tên thư mục chứa file này.
                Console.WriteLine("Directory Name: " + testFile.DirectoryName);
            }
            else
            {
                Console.WriteLine(testFile.FullName + " does not exist.");
            }
            Console.Read();
        }
    }
}
