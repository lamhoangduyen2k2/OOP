using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            double divResult = 0;
            starAgain:
            try
            {
                Console.WriteLine("Enter the first number");
                firstNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number");
                secondNumber = int.Parse(Console.ReadLine());

                divResult = firstNumber / secondNumber;
                Console.WriteLine("Result = " + divResult);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide by zero");
                goto starAgain;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid Input");
                goto starAgain;
            }
        }
    }
}
