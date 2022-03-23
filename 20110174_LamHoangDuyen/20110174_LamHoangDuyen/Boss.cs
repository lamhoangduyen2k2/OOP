using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20110174_LamHoangDuyen
{
    public class Boss : Employee
    {
        private decimal salary;

        public Boss(string firstNameValue, string lastNameValue, int birhthMonth, int birhthDay, int birthYear, int hireMonth, int hirethDay, int hireYear, decimal salaryValue) : base(firstNameValue, lastNameValue, birhthMonth, birhthDay, birthYear, hireMonth, hirethDay, hireYear)
        {
            WeeklySalary = salaryValue;
        }

        public decimal WeeklySalary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value > 0)
                    salary = value;
            }
        }

        public override decimal Earnings()
        {
            return WeeklySalary;
        }

        public override string ToString()
        {
            return "Boss: " + base.ToString();
        }
    }
}
