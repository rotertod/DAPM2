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
    public partial class AddNhanVien : Form
    {
        function fn = new function();
        String query;
        public AddNhanVien()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNhanVien_Load(object sender, EventArgs e)
        {
            this.Location = new Point(450, 131);
        }
        public void clearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtEmaild.Clear();
            txtAddress.Clear();
            txtUniqueID.Clear();
            txtDesignation.SelectedIndex = -1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "" && txtName.Text != "" && txtFather.Text != "" && txtMother.Text != "" && txtEmaild.Text != "" && txtAddress.Text != "" && txtUniqueID.Text != "" && txtDesignation.SelectedIndex != -1)
            {
                // Kiểm tra xem dữ liệu nhập vào có thể chuyển đổi sang kiểu Int64 không
                if (!Int64.TryParse(txtMobile.Text, out Int64 emobile))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                String ename = txtName.Text;
                String efname = txtFather.Text;
                String emname = txtMother.Text;
                String eemai = txtEmaild.Text;
                String epaddress = txtAddress.Text;
                String eidproof = txtUniqueID.Text;
                String edesignation = txtDesignation.Text;

                // Sửa câu truy vấn SQL bằng cách thêm dấu nháy đơn và dấu nháy kép
                query = "insert into newEmployee(emobile,ename,efname,emname,eemail,epaddress,eidproof,edesignation) values ('" + emobile + "','" + ename + "','" + efname + "','" + emname + "','" + eemai + "','" + epaddress + "','" + eidproof + "','" + edesignation + "')";
                fn.setData(query, "Đã thêm nhân viên mới thành công");
                clearAll();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnUpdateDeleteEmployee_Click(object sender, EventArgs e)
        {
            UpdateDeleteEmployee ude = new UpdateDeleteEmployee();
            ude.Show();
        }
    }
}
