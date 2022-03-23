using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    class Program
    {
        public static string GetString(Employee worker)
        {
            return worker.ToString() + " earned " + worker.Earnings().ToString("C") + "\n" + worker.ToEmployeeString() + "\n\n";
        }
        static void Main(string[] args)
        {
            Boss boss = new Boss("John", "Smith",12,2,1985,2,12,2020, 800);
            CommissionWorker commissionWorker = new CommissionWorker("Sue", "Jone",10,5,1990,3,21,2021, 400, 3, 150);
            PieceWorker pieceWorker = new PieceWorker("Bob", "Lewis",4,30,1995,6,13,2021, Convert.ToDecimal(2.5), 200);
            HourlyWorker hourlyWorker = new HourlyWorker("Karen", "Price",9,9,2000,10,12,2021, Convert.ToDecimal(13.75), 50);

            Employee employee = boss;
            string output = GetString(employee);

            employee = commissionWorker;
            output += GetString(employee);

            employee = pieceWorker;
            output += GetString(employee);

            employee = hourlyWorker;
            output += GetString(employee);

            MessageBox.Show(output, "Demonstrating Polymorphism", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
