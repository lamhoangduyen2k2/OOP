using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _049
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int x = 0;
            x = random.Next(1, 13);
            Console.WriteLine("Month: " + x);

            double y = 0;
            y = random.NextDouble() * 10;
            Console.WriteLine("Random double no is: " + Math.Round(y,2));
        }
    }
}
