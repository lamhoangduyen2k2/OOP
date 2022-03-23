using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110174_LamHoangDuyen
{
    public partial class Form1 : Form
    {
        Boss boss = new Boss("John", "Smith", 1, 2, 6, 1, 3, 12, 2016);
        CommissionWorker commissionWorker = new CommissionWorker("Sue", "Jones", 12, 2, 1969, 3, 12, 2016, 400, 3, 150);
        PieceWorker pieceWorker = new PieceWorker("Bob", "Lewis", 2, 6, 1989, 3, 12, 2017, Convert.ToDecimal(2.5), 200);
        HourlyWorker hourlyWorker = new HourlyWorker("Karen", "Price", 2, 2, 1989, 3, 11, 2018, Convert.ToDecimal(13.75), 50);
        public string output, output1, thutu, op = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(output, "Lâm Hoàng Duyên", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter swt = new StreamWriter("data.txt"))
            {
                swt.WriteLine(output);
            }
        }

        private void btDis_Click(object sender, EventArgs e)
        {
            if (op == output)
            {
                return;
            }
            else
            {
                op = op + output;
                lblHienThi.Text = "Kết quả: \n" + op;
            }

        }

        private void btSet_Click(object sender, EventArgs e)
        {
            
            if (txtHuman.Text == "1" || txtHuman.Text == "Boss" || txtHuman.Text == "boss")
            {
                thutu = "1";
                output1 = boss + "-- Earned " + boss.Earnings().ToString("C") + "\n\n";
                lblDis.Text = thutu + ": " + output1;
                output = output1;
            }
            else if (txtHuman.Text == "2" || txtHuman.Text == "Commission" || txtHuman.Text == "commission")
            {
                thutu = "2";
                output1 = commissionWorker + "-- Earned " + commissionWorker.Earnings().ToString("C") + "\n\n";
                lblDis.Text = thutu + ": " + output1;
                output += output1;
            }
            else if (txtHuman.Text == "3" || txtHuman.Text == "Piece" || txtHuman.Text == "piece")
            {
                thutu = "3";
                output1 = pieceWorker + "-- Earned " + pieceWorker.Earnings().ToString("C") + "\n\n";
                lblDis.Text = thutu + ": " + output1;
                output += output1;
            }
            else if (txtHuman.Text == "4" || txtHuman.Text == "Hourly" || txtHuman.Text == "hourly")
            {
                thutu = "4";
                output1 = hourlyWorker + "-- Earned " + hourlyWorker.Earnings().ToString("C") + "\n\n";
                lblDis.Text = thutu + ": " + output1;
                output += output1;
            }
            else 
            {
                lblDis.Text = "Sai dữ liệu";
            }
        }
    }
}
