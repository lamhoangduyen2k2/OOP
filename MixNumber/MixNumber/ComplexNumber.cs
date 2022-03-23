using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixNumber
{
    class ComplexNumber
    {
        private int real;
        private int imaginary;
        public int Real
        {
            get { return this.real; }
            set { this.real = value; }
        }

        public int Imaginary
        {
            get { return this.imaginary; }
            set { this.imaginary = value; }
        }
        public ComplexNumber()
        {
            Real = 0;
            Imaginary = 0;
        }

        public ComplexNumber(int a, int b)
        {
            Real = a;
            Imaginary = b;
        }
        public static ComplexNumber operator+(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.real + b.real, a.imaginary + b.imaginary);
        }
        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.real - b.real, a.imaginary - b.imaginary);
        }
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber((a.real * b.real)-(a.imaginary*b.imaginary), (a.real*b.imaginary)+(a.imaginary*b.real));
        }
        public override string ToString()
        {
            if(this.imaginary>0)
                return this.real+"+"+this.imaginary + "i";
            return this.real + "" + this.imaginary + "i";
        }
    }
}
