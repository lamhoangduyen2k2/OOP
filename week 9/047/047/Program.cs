using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _047
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 5.97;
            Console.WriteLine("Ceiling: " + Math.Ceiling(x));
            Console.WriteLine("Floor: " + Math.Floor(x));
            Console.WriteLine("Round: " + Math.Round(x, 2));
            Console.WriteLine("Truncate: " + Math.Truncate(x));
        }
    }
}
