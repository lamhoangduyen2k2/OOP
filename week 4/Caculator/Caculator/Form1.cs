using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Form1 : Form
    {
        ComplexNumber x = new ComplexNumber();
        ComplexNumber y = new ComplexNumber();

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            statusLabel.Text = x + "-" + y + "=" + (x - y);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text = x + "+" + y + "=" + (x + y);
        }

        private void mutiplyButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text = x + "*" + y + "=" + (x * y);
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            x.Real = Int32.Parse(realTextBox.Text);
            x.Imaginary = Int32.Parse(imaginaryTextBox.Text);
            realTextBox.Clear();
            imaginaryTextBox.Clear();
            statusLabel.Text = "First Complex Number is: " + x;
        }

        private void secondButton_Click(object sender, EventArgs e)
        {
            y.Real = Int32.Parse(realTextBox.Text);
            y.Imaginary = Int32.Parse(imaginaryTextBox.Text);
            realTextBox.Clear();
            imaginaryTextBox.Clear();
            statusLabel.Text = "Second Complex Number is: " + y;
        }
    }
}
