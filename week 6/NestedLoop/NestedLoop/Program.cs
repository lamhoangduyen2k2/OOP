using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 30; i++)
            {
                for (int j = 1; j <= 30; j++)
                {
                    Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }
    }
}
