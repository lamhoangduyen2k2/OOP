using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReWritePoint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point point = new Point(72, 115);
            Circle2 circle = new Circle2(10, 20, 30);

            string output = "X coordinate is " + point.X + "\n" + "Y coordinate is " + point.Y;

            point.X = 10;
            point.Y = 10;

            //display
            output += "\n\nThe new location of point is " + point;
            output += "\n\nThe new location of point is " + circle;
            MessageBox.Show(output, "Demonstrating Class Point");
        }
    }
}
