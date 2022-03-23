using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
    public class CommissionWorker : Employee
    {
        private decimal commission;
        private int quantity;
        private decimal salary;

        public CommissionWorker(string firstNameValue, string lastNameValue, decimal salaryValue, decimal commissionValue, int quantityVlaue) :base(firstNameValue,lastNameValue)
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