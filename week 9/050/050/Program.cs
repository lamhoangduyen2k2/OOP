using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 1, 10, 100, 1000, 10000 };
            string[] weekdays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            foreach (var item in weekdays)
            {
                Console.WriteLine(item);
            }
        }
    }
}
