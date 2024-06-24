using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class AllEmployee : Form
    {
        function fn = new function();
        String query;
        public AllEmployee()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void Load_NhanVien()
        {
            query = "SELECT * FROM newEmployee";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

            guna2DataGridView1.Columns[0].HeaderText = "ID";
            guna2DataGridView1.Columns[1].HeaderText = "SDT";
            guna2DataGridView1.Columns[2].HeaderText = "Ho Ten";
            guna2DataGridView1.Columns[3].HeaderText = "Ten Cha";
            guna2DataGridView1.Columns[4].HeaderText = "Ten Me";
            guna2DataGridView1.Columns[5].HeaderText = "Email";
            guna2DataGridView1.Columns[6].HeaderText = "Dia chi";
            guna2DataGridView1.Columns[7].HeaderText = "CCCD";
            guna2DataGridView1.Columns[8].HeaderText = "Chuc vu";
            guna2DataGridView1.Columns[9].HeaderText = "TrangThaiLamViec";
            guna2DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void AllEmployee_Load(object sender, EventArgs e)
        {
            Load_NhanVien();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
