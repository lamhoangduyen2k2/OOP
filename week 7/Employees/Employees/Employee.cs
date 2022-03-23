using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
    public abstract class Employee
    {
        private string firstName;
        private string lastName;

        public Employee(string firstNameValue, string lastNameValue)
        {
            FirstName = firstNameValue;
            LastName = lastNameValue;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get => default;
            set
            {
            }
        }

        public abstract decimal Earnings();

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}