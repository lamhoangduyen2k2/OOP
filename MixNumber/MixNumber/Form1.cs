using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixNumber
{
    public partial class Form1 : Form
    {
        ComplexNumber num1=new ComplexNumber();
        ComplexNumber num2=new ComplexNumber();
        public Form1()
        {
            InitializeComponent();
        }

        private void Add1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Real.Text);
            int y = int.Parse(imagine.Text);
            num1 = new ComplexNumber(x,y);
            Result.Text = "First Complex is: " + num1;
            Real.Text = "";
            imagine.Text = "";
        }

        private void Add2_Click(object sender, EventArgs e)
        {
            num2 = new ComplexNumber(int.Parse(Real.Text), int.Parse(imagine.Text));
            Real.Text = "";
            imagine.Text = "";
            Result.Text = "Second Complex is: " + num2;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Result.Text = "x + y = " + (num1 + num2).ToString();
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            ComplexNumber a = num1 - num2;
            Result.Text = "x - y = "+ (num1 - num2).ToString();
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            ComplexNumber a = num1 * num2;
            Result.Text = "x * y = "+ (num1 * num2).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Real_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
