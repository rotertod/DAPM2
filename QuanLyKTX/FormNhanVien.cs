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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            AddNewRoom anr = new AddNewRoom();
            anr.Show();
        }

        private void btnAllNewStudent_Click(object sender, EventArgs e)
        {
            AllStudent asl = new AllStudent();
            asl.Show();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            fmLogin fn = new fmLogin();
            fn.Show();
            this.Close();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
