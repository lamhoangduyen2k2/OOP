using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _082
{
    class Program
    {
        static void Main(string[] args)
        {
            string weekDayName = WeekDay.Monday.ToString();
            WeekDay day = WeekDay.Sunday;
            Console.WriteLine((int)day);
        }
    }
    enum WeekDay
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday = 40,
        Saturday = 50,
        Sunday = 60
    }
}
