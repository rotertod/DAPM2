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
    public partial class UpdateDeleteEmployee : Form
    {
        function fn = new function();
        String query;
        public UpdateDeleteEmployee()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateDeleteEmployee_Load(object sender, EventArgs e)
        {
            this.Location = new Point(450, 131);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            query = "SELECT * FROM newEmployee WHERE " +
                    "emobile = '" + txtMobile.Text + "' AND " +
                    "ename LIKE '%" + txtName.Text + "%' AND " +
                    "efname LIKE '%" + txtFather.Text + "%' AND " +
                    "emname LIKE '%" + txtMother.Text + "%' AND " +
                    "eemail LIKE '%" + txtEmailID.Text + "%' AND " +
                    "epaddress LIKE '%" + txtAddress.Text + "%' AND " +
                    "eidproof LIKE '%" + txtUniqueID.Text + "%' AND " +
                    "edesignation LIKE '%" + txtDesignation.Text + "%' AND " +
                    "working LIKE '%" + txtWorking.Text + "%'";

            
            DataSet ds = fn.GetData(query);

            
            if (ds.Tables[0].Rows.Count != 0)
            {
                
                txtName.Text = ds.Tables[0].Rows[0]["ename"].ToString();
                txtFather.Text = ds.Tables[0].Rows[0]["efname"].ToString();
                txtMother.Text = ds.Tables[0].Rows[0]["emname"].ToString();
                txtEmailID.Text = ds.Tables[0].Rows[0]["eemail"].ToString();
                txtAddress.Text = ds.Tables[0].Rows[0]["epaddress"].ToString();
                txtUniqueID.Text = ds.Tables[0].Rows[0]["eidproof"].ToString();
                txtDesignation.Text = ds.Tables[0].Rows[0]["edesignation"].ToString();
                txtWorking.Text = ds.Tables[0].Rows[0]["working"].ToString();
            }
            else
            {
                
                MessageBox.Show("Hồ sơ này không tồn tại", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                clearAll();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMobile.Text))
            {
                Int64 mobile;
                if (!Int64.TryParse(txtMobile.Text, out mobile))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                String name = txtName.Text;
                String fname = txtFather.Text;
                String mname = txtMother.Text;
                String email = txtEmailID.Text;
                String id = txtUniqueID.Text;
                String paddress = txtAddress.Text;
                String designation = txtDesignation.Text;
                String working = txtWorking.Text;

                query = "UPDATE newEmployee SET ename = '" + name + "', efname = '" + fname + "', emname = '" + mname + "', eemail = '" + email + "', epaddress = '" + paddress + "', eidproof = '" + id + "', edesignation = '" + designation + "', working = '" + working + "' WHERE emobile = " + mobile + "";
                fn.setData(query, "Cập nhật dữ liệu thành công.");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        public void clearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtEmailID.Clear();
            txtUniqueID.Clear();
            txtAddress.Clear();
            txtDesignation.SelectedIndex = -1;
            txtWorking.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "DELETE FROM newEmployee WHERE emobile = " + txtMobile.Text + "";
                fn.setData(query, "Đã xoá hồ sơ nhân viên");
                clearAll();
            }
        }

        private void txtWorking_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
