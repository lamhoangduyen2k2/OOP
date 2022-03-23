using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChiaCho0_Form
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

        private void bt_Div_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            try
            {
                int numerator = Convert.ToInt32(textBox1.Text);
                int denominator = Convert.ToInt32(textBox2.Text);
                int result = numerator / denominator;
                label3.Text = result.ToString();
            }
            catch(DivideByZeroException divideByZeroException)
            {
                MessageBox.Show(divideByZeroException.Message, "So bi chia la 0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(FormatException)
            {
                MessageBox.Show("Nhap 2 so nguyen", "Bao sai", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
