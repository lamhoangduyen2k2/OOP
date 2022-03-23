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

namespace Yeucau_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo testFile = new FileInfo("C:/test/test.txt");
            if (rdbt.Checked == true)
            {
                if(testFile.Exists)
                {
                    rtShow.Text = testFile.FullName + "exist."
                        + "Creation time: " + testFile.CreationTime
                        + "Last Write Time " + testFile.LastWriteTime
                        + "Directory Name: " + testFile.DirectoryName;
                }
                else
                {
                    rtShow.Text = testFile.FullName + "does not exist.";
                }
            }
            if (rbt_CreateDic.Checked == true)
            {
                string dirPath = "C:/thku01/CSharp";
                bool exist = Directory.Exists(dirPath);

                //Neu ko ton tai, tao thu muc nay
                if(!exist)
                {
                    rtShow.Text = dirPath + "does not exist." + "\n" +
                        "Create directory: " + dirPath + "\n" +
                        "Nhan them 1 lan nua de hien thi thong tin thu muc vua tao";

                    //Tao thu muc
                    Directory.CreateDirectory(dirPath);
                }
                else
                {
                    //Thu muc cha
                    DirectoryInfo parentInfo = Directory.GetParent(dirPath);
                    rtShow.Text = "Directory Information " + dirPath + "\n" +
                    //In ra cac thong tin thu muc tren
                    //Thoi diem tao thu muc
                    "Creation time: " + Directory.GetCreationTime(dirPath) + "\n" +

                    //Thoi diem cuoi cung thu muc co su thay doi
                    "Lart Write Time: " + Directory.GetLastWriteTime(dirPath) + "\n" +
                    "Parent directory: " + parentInfo.FullName;
                 }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtShow.Text = "";
        }
    }
}
