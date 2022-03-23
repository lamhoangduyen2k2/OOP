using HinhHoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ThuaKe_Form
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
            TamGiac tg = new TamGiac(dinhA, dinhB, dinhC);
            Graphics g = pictureBox1.CreateGraphics();
            tg.Ve(g);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Point dinhA = new Point(60, 10);
            Point dinhB = new Point(60, 100);
            DoanThang doanThang = new DoanThang(dinhA, dinhB);
            Graphics g = pictureBox1.CreateGraphics();
            doanThang.Ve(g);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Point dinhB = new Point(90, 10);
            Point dinhC = new Point(200, 10);
            Point dinhA = new Point(90, 50);
            Point dinhD = new Point(200, 100);
            TuGiac tg = new TuGiac(dinhA, dinhB, dinhC,dinhD);
            Graphics g = pictureBox1.CreateGraphics();
            tg.Ve(g);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HinhVuong a = new HinhVuong();
            Graphics g = pictureBox1.CreateGraphics();
            a.Ve(g);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HinhTron a = new HinhTron();
            Graphics g = pictureBox1.CreateGraphics();
            a.Ve(g);
        }
    }
}
