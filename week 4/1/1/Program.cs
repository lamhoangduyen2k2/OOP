using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public static class StaticClass
    {
        public static void DoWork()
        {
            ++callCount;
            Console.WriteLine("StaticClass.DoWork()");
        }
        public class NestedClass
        {
            public NestedClass()
            {
                Console.WriteLine("NestedClass.NestedClass()");
            }
        }
        private static long callCount = 0;
        public static long CallCount
        {
            get
            {
                return callCount;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lam Hoang Duyen 20110174");
            StaticClass.DoWork();
            StaticClass.NestedClass nested = new StaticClass.NestedClass();
            Console.WriteLine("CallCount={0}", StaticClass.CallCount);
        }
    }
}