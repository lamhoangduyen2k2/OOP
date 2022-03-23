using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class CommissionWorker : Employee
    {
        private decimal commission;
        private int quantity;
        private decimal salary;

        public CommissionWorker(string firstNameValue, string lastNameValue, int birhthMonth, int birhthDay, int birthYear, int hireMonth, int hirethDay, int hireYear, decimal salaryValue, decimal commissionValue, int quantityVlaue) : base(firstNameValue, lastNameValue, birhthMonth, birhthDay, birthYear, hireMonth, hirethDay, hireYear)
        {
            WeeklySalary = salaryValue;
            Commission = commissionValue;
            Quantity = quantityVlaue;
        }

        public decimal Commission
        {
            get
            {
                return commission;
            }
            set
            {
                commission = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public decimal WeeklySalary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public override decimal Earnings()
        {
            return WeeklySalary + Commission * Quantity;
        }

        public override string ToString()
        {
            return "CommissionWorker: " + base.ToString();
        }
    }
}
