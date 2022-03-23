using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoAm_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public double SquareRoot(double operand)
        {
            if (operand < 0)
                throw new NegativeNumberException("Không tính số âm cho căn bậc 2");
            return Math.Sqrt(operand);

        }
        private void bt_Cal_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            try
            {
                double result = SquareRoot(double.Parse(textBox1.Text));
                label2.Text = result.ToString();
            }
            catch(FormatException notInteger)
            {
                MessageBox.Show(notInteger.Message, "Lỗi sai", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(NegativeNumberException error)
            {
                MessageBox.Show(error.Message, "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    class NegativeNumberException: ApplicationException
    {
        public NegativeNumberException():base("Illegal operation for a negative number")
        { }
        public NegativeNumberException(string message):base(message)
        { }
        public NegativeNumberException(string message, Exception inner):base(message, inner)
        {
        }

    }
}
