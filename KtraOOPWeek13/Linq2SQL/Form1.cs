using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq2SQL
{
    public partial class Form1 : Form
    {
        Table nv = new Table();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            qlyNVienDataContext db = new qlyNVienDataContext();
            var list = (from s in db.Tables select s).ToList();
            dataGridView1.DataSource = list;
            txtEmID.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtDept.DataBindings.Clear();
            txtEmID.DataBindings.Add("text", list, "emid");
            txtName.DataBindings.Add("text", list, "name");
            txtDept.DataBindings.Add("text", list, "dept");
            // TODO: This line of code loads data into the '_Ktra_OOP_week13DataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this._Ktra_OOP_week13DataSet.Table);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            qlyNVienDataContext db = new qlyNVienDataContext();
            nv.emID = txtEmID.Text;
            nv.Name = txtName.Text;
            nv.Dept = txtDept.Text;
            db.Tables.InsertOnSubmit(nv);
            try
            {
                db.SubmitChanges();
            }
            catch
            {
                MessageBox.Show("Nhân viên đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Form1_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            qlyNVienDataContext db = new qlyNVienDataContext();
            nv = db.Tables.Where(s => s.emID == txtEmID.Text).Single();
            nv.Name = txtName.Text;
            nv.Dept = txtDept.Text;

            db.SubmitChanges();
            Form1_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            qlyNVienDataContext db = new qlyNVienDataContext();
            nv = db.Tables.Where(s => s.emID == txtEmID.Text).Single();
            nv.Name = txtName.Text;
            nv.Dept = txtDept.Text;
            db.Tables.DeleteOnSubmit(nv);
            db.SubmitChanges();
            Form1_Load(sender, e);
        }
        private void txtSearch_KeyUp(object sender, EventArgs e)
        {
            qlyNVienDataContext db = new qlyNVienDataContext();
            var list = (from s in db.Tables where s.emID.Contains(txtSearch.Text) select s).ToList();
            dataGridView1.DataSource = list;
            txtEmID.DataBindings.Clear();

            txtName.DataBindings.Clear();
            txtDept.DataBindings.Clear();
            txtEmID.DataBindings.Add("text", list, "emID");
            txtName.DataBindings.Add("text", list, "Name");
            txtDept.DataBindings.Add("text", list, "Dept");
        }
    }
}
