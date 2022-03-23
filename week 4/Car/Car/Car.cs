using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {
        public string petName;
        public int currSpeed;
        public Car(string pn)
        {
            petName = pn;
        }
        public Car() //Construction
        {
            petName = "Chuck";
            currSpeed = 10;
        }
        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }

        public void PrintState()
        {
            Console.WriteLine("Name: {0}", petName);
            Console.WriteLine("Speed: {0}", currSpeed);
        }

    }
}
