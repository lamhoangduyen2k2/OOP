using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh4
{
    class Program
    {
        static void Main(string[] args)
        {
            Samsung samsung = new Samsung("Galaxy", 2020, "white", 123);
            samsung.Information();
            samsung.HoatDong();
            samsung.UsingGSM();
            Console.WriteLine();
            LG lg = new LG("Olet", 2021, "gray", 093);
            lg.Information();
            lg.HoatDong();
            lg.UsingGSM();
            Console.WriteLine();
            IPhone phone = new IPhone("Iphone 12 pro max", 2020, "blue", 348);
            phone.Information();
            phone.HoatDong();
            phone.UsingGSM();
        }
    }
}
