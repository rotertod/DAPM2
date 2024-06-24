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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            CenterToScreen();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            fmLogin fn = new fmLogin();
            fn.Show();
            this.Close();
        }

        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            AddNewRoom anr = new AddNewRoom();
            anr.Show();
        }

        private void btnNewStudent_Click_1(object sender, EventArgs e)
        {
            Student nst = new Student();
            nst.Show();
        }

        private void btnAllNewStudent_Click(object sender, EventArgs e)
        {
            AllStudent asl = new AllStudent();
            asl.Show();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void btnEmploye_Click(object sender, EventArgs e)
        {
            AddNhanVien ne = new AddNhanVien();
            ne.Show();
        }

        private void btnAllEmployee_Click(object sender, EventArgs e)
        {
            AllEmployee wt = new AllEmployee();
            wt.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            FormReport wtf = new FormReport();
            wtf.Show();
        }
    }
}
