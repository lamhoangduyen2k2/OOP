using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Date
    {
        private int month;
        private int day;
        private int year;

        public Date(int theMonth, int theDay, int theYear)
        {
            if (theMonth > 0 && theMonth <= 12)
                month = theMonth;
            else
            {
                month = 1;
                Console.WriteLine("Thang {0} khong hop le. Tam thoi dua ve 1.", theMonth);
            }

            year = theYear;
            day = CheckDay(theDay);
        }

        public string ToDateString()
        {
            return month + "/" + day + "/" + year;
        }

        private int CheckDay(int testDay)
        {
            int[] daysperMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (testDay > 0 && testDay <= daysperMonth[month])
                return testDay;

            if (month == 2 && testDay == 29 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
                return testDay;
            Console.WriteLine("Ngay {0} khong hop le. Tam thoi dua ve 1. ", testDay);
            return 1;
        }
    }
}
