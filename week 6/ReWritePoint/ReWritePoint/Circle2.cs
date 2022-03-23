using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReWritePoint
{
    class Circle2:Point
    {
        private double radius;

        public Circle2(int xValue, int yValue, double radiusValue)
        {
            x = xValue;
            y = yValue;
            Radius = radius;
        }

        public double Radius
        {
            get { return radius; }
            set 
            {
                if (value >= 0)
                    radius = value; 
            }
        }

        public double Diameter()
        {
            return radius * 2;
        }

        public double Circumference()
        {
            return Math.PI * Diameter();
        }

        public virtual double area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override string ToString()
        {
            //base.ToString();
            return "Center = [" + x + ", " + y + "]" + "; Radius = " + radius;
        }
    }
}
