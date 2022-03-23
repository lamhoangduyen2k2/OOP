using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    class OperatorOvrldDemo
    {
        private int intX;
        private int intY;
        public OperatorOvrldDemo() { }
        public OperatorOvrldDemo(int intI, int intJ)
        {
            intX = intI;
            intY = intJ;
        }
        public void ShowXY()
        {
            Console.WriteLine(intX + " " + intY);
        }
        public static OperatorOvrldDemo operator +(OperatorOvrldDemo objcom1, OperatorOvrldDemo objcom2)
        {
            OperatorOvrldDemo objcom = new OperatorOvrldDemo();
            objcom.intX = objcom1.intX + objcom2.intX;
            objcom.intY = objcom1.intY + objcom2.intY;
            return objcom;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OperatorOvrldDemo objcom1 = new OperatorOvrldDemo(10, 20);
            objcom1.ShowXY();
            OperatorOvrldDemo objcom2 = new OperatorOvrldDemo(30, 40);
            objcom2.ShowXY();
            OperatorOvrldDemo objcom3 = new OperatorOvrldDemo();
            objcom3 = objcom1 + objcom2;
            objcom3.ShowXY();
        }
    }
}
