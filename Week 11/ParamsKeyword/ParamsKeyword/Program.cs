using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopThroughArray("Jack", "Tiffany", "Sandra", "Charles");
            Console.WriteLine("-----------------");
            LoopThroughArray("Ahmad", "Mark", "Thomas", "Emma", "Jack", "Tom");
        }

        public static void LoopThroughArray(params string[] names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
