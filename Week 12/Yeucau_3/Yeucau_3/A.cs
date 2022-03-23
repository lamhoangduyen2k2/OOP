using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeucau_3
{
    class A
    {
        string filePath = @"C:\test\test1.txt";

        string[] lines;
        string str;

        public void ReadFile()
        {
            if(File.Exists(filePath))
            {
                lines = File.ReadAllLines(filePath);
                Console.WriteLine("\n Doc theo dong:");
                for(int i = 0; i < lines.Length; i++)
                {
                    Console.WriteLine("Line {0}: {1}", i, lines[i]);
                }
                Console.WriteLine();
                Console.WriteLine("\n Doc het van ban:");
                str = File.ReadAllText(filePath);
                Console.WriteLine("Chuoi can doc:\n{0}", str);
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }
    }
}
