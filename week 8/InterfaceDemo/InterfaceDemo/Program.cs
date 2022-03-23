using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
	public interface Calculation
	{
		void Salary();
	}
	public class Accounts : Calculation
	{
		private int basic = 6000;
		public void Salary()
		{
			Console.WriteLine("Salary(basic * 5) = " + basic * 5);
		}
	}
	public class HR : Calculation
	{
		private int basic = 4000;
		public void Salary()
		{
			Console.WriteLine("Salary (basic * 2) = " + basic * 2);
		}
	}
	public class InterfaceDemo
	{
		public static void Main()
		{
			Accounts objacc = new Accounts();
			Console.WriteLine("Accounts Department");
			objacc.Salary();
			Console.WriteLine();

			HR objhr = new HR();
			Console.WriteLine("HR department");
			objhr.Salary();
		}
	}
}
