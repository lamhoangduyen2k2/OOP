using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Chuck = new Car();
            Chuck.PrintState();
            Car mary = new Car("Mary");
            mary.PrintState();
            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();

            Console.ReadLine();

        }
    }
}
