using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrl = new ArrayList();
            arrl.Add("Hoc");
            arrl.Add("LT");
            arrl.Add("C#");
            arrl.RemoveAt(2);
            arrl.Insert(2, "Java");
            Console.WriteLine("Capacity: " + arrl.Capacity);
            Console.WriteLine("Count: " + arrl.Count);
            Console.WriteLine();
            Console.WriteLine("ArrayList chua noi dung:");
            foreach (string str in arrl)
            {
                Console.WriteLine(str);
            }
        }
    }
}
