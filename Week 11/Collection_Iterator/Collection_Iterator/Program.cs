using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection_Iterator
{
    class IterEx
    {
        public string[] item = { "Lap", "Trinh", "C#" };
        public IEnumerator GetEnumerator()
        {
            foreach (string s in item)
            {
                yield return s;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IterEx ite = new IterEx();
            foreach (string s in ite)
            {
                Console.Write("{0} ", s);
            }
            Console.WriteLine();
        }
    }
}
