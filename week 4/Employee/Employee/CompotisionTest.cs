using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    static class CompotisionTest
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Employee e = new Employee("Bob", "Jones", 2, 2, 1989, 3, 12, 2016);
            MessageBox.Show(e.ToEmployeeString(), "Testing Class Employee");
        }
    }
}
