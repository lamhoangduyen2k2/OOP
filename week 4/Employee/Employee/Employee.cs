using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private Date birthDate;
        private Date hireDate;

        public Employee(string first, string last, int birthMonth, int birthDay, int birthYear, int hireMonth, int hireDay, int hireYear)
        {
            firstName = first;
            lastName = last;

            birthDate = new Date(birthMonth, birthDay, birthYear);
            hireDate = new Date(hireMonth, hireDay, hireYear);
        }
        public string ToEmployeeString()
        {
            return lastName + ", " + firstName + " Hired: " + hireDate.ToDateString() + " Birthday: " + birthDate.ToDateString();
        }
    }
}
