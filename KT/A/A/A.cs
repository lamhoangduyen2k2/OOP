using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace A
{
    class A
    {
        DirectoryInfo dirInfo = new DirectoryInfo(@"D:/Duyên");
        public void showID()
        {
            Console.WriteLine("Creation time: " + dirInfo.CreationTime);
            Console.WriteLine("Last Write Time " + dirInfo.LastAccessTime);
            Console.WriteLine("Directory Name: " + dirInfo.FullName);
            DirectoryInfo[] childDirs = dirInfo.GetDirectories();
            FileInfo[] childFiles = dirInfo.GetFiles();
            foreach (DirectoryInfo chilDir in childDirs)
            {
                Console.WriteLine("- Directory: " + chilDir.FullName);
            }
            foreach (FileInfo childFile in childFiles)
            {
                Console.WriteLine("- File: " + childFile.FullName);
            }
        }
    }
}
