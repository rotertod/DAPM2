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
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool loginSuccessful = false;

            if (txtUsername.Text == "DangHai" && txtPassword.Text == "123")
            {
                DashBoard dbs = new DashBoard();
                dbs.Show();
                this.Hide();
                loginSuccessful = true;
            }

            if (txtUsername.Text == "AnhNhat" && txtPassword.Text == "123")
            {
                FormNhanVien dbs = new FormNhanVien();
                dbs.Show();
                this.Hide();
                loginSuccessful = true;
            }
            if (!loginSuccessful)
            {
                MessageBox.Show(this, "Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng thử lại.", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void fmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
           
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fmLogin_Load_1(object sender, EventArgs e)
        {

        }

        private void fmLogin_Enter(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
