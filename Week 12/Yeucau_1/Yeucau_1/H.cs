﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeucau_1
{
    class H
    {
        FileInfo fileInfo = new FileInfo("C:/test/test.txt");
        public void renameInfo()
        {
            if (!fileInfo.Exists)
            {
                Console.WriteLine(fileInfo.FullName + " does not exist.");
                Console.Read();
                return;
            }
            Console.WriteLine(fileInfo.FullName + " exist");
            Console.WriteLine("Please enter a new name for this file:");

            // Một String mà người dùng nhập vào.
            // Ví dụ: C:/test/test2.txt
            string newFilename = Console.ReadLine();

            if (newFilename == String.Empty)
            {
                Console.WriteLine("You not enter new file name. Cancel rename");
                Console.Read();
                return;
            }
            FileInfo newFileInfo = new FileInfo(newFilename);

            // Nếu 'newFileInfo' tồn tại (Không thể đổi tên).
            if (newFileInfo.Exists)
            {
                Console.WriteLine("Can not rename file to " + newFileInfo.FullName + ". File already exist.");
                Console.Read();
                return;
            }
            // Tạo thư mục cha của 'newFileInfo'.
            newFileInfo.Directory.Create();

            // Đổi tên file.
            fileInfo.MoveTo(newFileInfo.FullName);

            // Refresh. 
            newFileInfo.Refresh();

            if (newFileInfo.Exists)
            {
                Console.WriteLine("The file was renamed to " + newFileInfo.FullName);
            }
            Console.ReadLine();
        }
    }
}
