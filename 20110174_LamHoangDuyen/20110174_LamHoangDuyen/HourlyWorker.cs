using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20110174_LamHoangDuyen
{
    public class HourlyWorker : Employee
    {
        private double hoursWorked;
        private decimal wage;

        public HourlyWorker(string firstNameValue, string LastNameValue, int birhthMonth, int birhthDay, int birthYear, int hireMonth, int hirethDay, int hireYear, decimal wageValue, double hoursWorkedValue) : base(firstNameValue, LastNameValue, birhthMonth, birhthDay, birthYear, hireMonth, hirethDay, hireYear)
        {
            Wage = wageValue;
            HoursWorked = hoursWorkedValue;
        }

        public double HoursWorked
        {
            get
            {
                return hoursWorked;
            }
            set
            {
                if (value > 0)
                    hoursWorked = value;
            }
        }

        public decimal Wage
        {
            get
            {
                return wage;
            }
            set
            {
                if (value > 0)
                    wage = value;
            }
        }

        public override decimal Earnings()
        {
            if (HoursWorked <= 40)
            {
                return Wage * Convert.ToDecimal(HoursWorked);
            }
            else
            {
                decimal basePay = Wage * Convert.ToDecimal(40);
                decimal overtimePay = Wage * 1.5M * Convert.ToDecimal(HoursWorked - 40);
                return basePay + overtimePay;
            }
        }

        public override string ToString()
        {
            return "HourlyWorker: " + base.ToString();
        }
    }
}
