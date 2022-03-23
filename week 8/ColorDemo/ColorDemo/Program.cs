using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorDemo
{
    abstract class Color
    {
        public abstract void Fill(string strColor);
    }
    class Blue : Color
    {
        public override void Fill(string strColor)
        {
            Console.WriteLine("Fill me up with " + strColor);
        }
    }
    class Green : Color
    {
        public override void Fill(string strColor)
        {
            Console.WriteLine("Fill me up with " + strColor);
        }
    }
    class ColorDemo
    {
        static void Main(string[] args)
        {
            Blue b = new Blue();
            b.Fill("Blue");

            Green g = new Green();
            g.Fill("Green");
        }
    }
}
