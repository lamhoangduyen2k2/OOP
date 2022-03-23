using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    class ComplexNumber
    {
        private int imaginary;
        private int real;

        public int Imaginary
        {
            get { return imaginary; }
            set
            { imaginary = value; }
        }

        public int Real
        {
            get { return real; }
            set { real = value; }
        }

        public ComplexNumber() { }

        public ComplexNumber(int a, int b)
        {
            Real = a;
            Imaginary = b;
        }

        public static ComplexNumber operator +(ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(x.Real + y.Real, x.Imaginary + y.Imaginary);
        }

        public static ComplexNumber operator -(ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(x.Real - y.Real, x.Imaginary - y.Imaginary);
        }

        public static ComplexNumber operator *(ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber((x.real * y.real) - (x.imaginary * y.imaginary), (x.real * y.imaginary) + (x.imaginary * y.real));
        }
        public static ComplexNumber Add(ComplexNumber x, ComplexNumber y)
        {
            return x + y;
        }

        public static ComplexNumber Sub(ComplexNumber x, ComplexNumber y)
        {
            return x - y;
        }

        public static ComplexNumber Mul(ComplexNumber x, ComplexNumber y)
        {
            return x * y;
        }
        public override string ToString()
        {
            if (imaginary > 0)
                return real + "+" + imaginary + "i";
            return real + "" + imaginary + "i";
        }
    }
}
