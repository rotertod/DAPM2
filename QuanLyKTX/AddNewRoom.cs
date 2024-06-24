using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace QuanLyKTX
{
    public partial class AddNewRoom : Form
    {
        function fn = new function();
        String query;
        public AddNewRoom()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewRoom_Load(object sender, EventArgs e)
        {
            this.Location = new Point(450, 131);
            labelRoom.Visible = false;
            labelRoomExist.Visible = false;

            query = "select * from room";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void Load_Data()
        {
            query = "SELECT * FROM room ";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "select * from room where roomNo = " + txtRoomNo2.Text + "";
            DataSet ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                labelRoom.Text = "Phòng Không Tồn Tại";
                labelRoom.Visible = true;
               
            }
            else
            {
                labelRoom.Text = "Đã Tìm Thấy Phòng";
                labelRoom.Visible = true;
                

            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM room WHERE roomNo =" + txtRoomNo1.Text + ".";
            DataSet ds = fn.GetData(query);
            string status = "Phòng này chưa có người";

            query = "insert into room (roomNo, roomStatus) values ('" + txtRoomNo1.Text.ToString() + "','" + status + "')";

            if (MessageBox.Show("Bạn có muốn thêm phòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                fn.setData(query, "Đã Thêm Phòng");
                
                Load_Data();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string status = "Phòng này chưa có người";

            query = "update room set roomStatus ='" + status + "'where roomNo =" + txtRoomNo2.Text + "";
            fn.setData(query, "Cập Nhật Trạng Thái Phòng Thành Công!!!");

            string status1 = "Phòng đã có người";

            query = "update room set Booked ='" + status1 + "'where roomNo =" + txtRoomNo2.Text + "";
            fn.setData(query, "Cập Nhật Tình Trạng Đặt Phòng Thành Công!!!");

            Load_Data();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập mã phòng chưa
            if (string.IsNullOrEmpty(txtRoomNo2.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phòng để xóa.");
                return;
            }

            // Lấy mã phòng từ TextBox
            string roomNo = txtRoomNo2.Text;

            // Xây dựng câu truy vấn DELETE
            query = "DELETE FROM room WHERE roomNo = '" + roomNo + "'";

            // Thực thi câu truy vấn xóa
            fn.setData(query, "Đã Xóa Phòng");

            // Làm mới dữ liệu trong DataGridView
            Load_Data();
        }

    }
}
