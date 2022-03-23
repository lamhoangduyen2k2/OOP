using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("_Out");
            stack.Push("_First");
            stack.Peek();
            Console.WriteLine("Phan Tren cua Stack");
            foreach (object i in stack)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine();
            stack.Push("_In");
            stack.Push("Last");
            //stack.Pop();
            foreach(object i in stack)
            {
                Console.Write("{0}", i);
            }
            Console.WriteLine();
        }
    }
}
