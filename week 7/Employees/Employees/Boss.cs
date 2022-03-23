using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
    public class Boss : Employee
    {
        private decimal salary;

        public Boss(string firstNameValue, string lastNameValue, decimal salaryValue) :base(firstNameValue, lastNameValue)
        {
            throw new System.NotImplementedException();
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