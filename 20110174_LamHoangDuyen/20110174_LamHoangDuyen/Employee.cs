using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20110174_LamHoangDuyen
{
    public abstract class Employee
    {
        private string firstName;
        private string lastName;
        private Date birthDate;
        private Date hireDate;
        public Employee(string firstNameValue, string lastNameValue, int birhthMonth, int birhthDay, int birthYear, int hireMonth, int hirethDay, int hireYear)
        {
            FirstName = firstNameValue;
            LastName = lastNameValue;
            birthDate = new Date(birhthMonth, birhthDay, birthYear);
            hireDate = new Date(hireMonth, hirethDay, hireYear);
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
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public abstract decimal Earnings();
        public override string ToString()
        {
            return FirstName + " " + LastName + "-- Hired: " + hireDate.ToDateString() + "-- Birthday" + birthDate.ToDateString();
        }
        public string ToEmployeeString()
        {
            return "Hire: " + hireDate.ToDateString() + "\n" + "Birthday: " + birthDate.ToDateString();
        }

    }
}

