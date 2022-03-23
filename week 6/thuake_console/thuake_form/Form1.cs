using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hinhhoc;

namespace thuake_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point dinhA = new Point(10, 10);
            Point dinhB = new Point(50, 50);
            Point dinhC = new Point(50, 20);
            tamgiac tg = new tamgiac(dinhA, dinhB, dinhC);
            Graphics g = pictureBox1.CreateGraphics();
            tg.Ve(g);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Point dinhA = new Point(100, 10);
            Point dinhB = new Point(100, 100);
            doanthang doanThang = new doanthang(dinhA, dinhB);
            Graphics g = pictureBox1.CreateGraphics();
            doanThang.Ve(g);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hinhvuong a = new hinhvuong();
            Graphics g = pictureBox1.CreateGraphics();
            a.Ve(g);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hinhtron a = new hinhtron();
            Graphics g = pictureBox1.CreateGraphics();
            a.Ve(g);
        }
    }
}
