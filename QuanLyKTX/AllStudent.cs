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

    public partial class AllStudent : Form
    {
        function fn = new function();
        String query;
        public AllStudent()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Load_Sinhvien()
        {
            query = "SELECT mobile,name,fname,mname,email,paddress,college,idproof,roomNo,living,IdClass from newStudent ";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

            guna2DataGridView1.Columns[0].HeaderText = "STT";
            guna2DataGridView1.Columns[0].Visible = false;
            guna2DataGridView1.Columns[1].HeaderText = "SDT";
            guna2DataGridView1.Columns[2].HeaderText = "Ho Ten";
            guna2DataGridView1.Columns[3].HeaderText = "Ten Cha";
            guna2DataGridView1.Columns[4].HeaderText = "Ten Me";
            guna2DataGridView1.Columns[5].HeaderText = "Email";
            guna2DataGridView1.Columns[6].HeaderText = "Dia chi";
            guna2DataGridView1.Columns[7].HeaderText = "Truong";
            guna2DataGridView1.Columns[8].HeaderText = "CCCD";
            guna2DataGridView1.Columns[9].HeaderText = "So Phong";
            guna2DataGridView1.Columns[10].HeaderText = "Living";
            guna2DataGridView1.Columns[11].HeaderText = "Ma Lop";
            guna2DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void AllStudent_Load(object sender, EventArgs e)
        {
            Load_Sinhvien();
            Load_RoomNumbers();
        }
        private void Load_RoomNumbers()
        {
            query = "SELECT DISTINCT roomNo FROM newStudent";
            DataSet ds = fn.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string roomNo = ds.Tables[0].Rows[i][0].ToString();
                comboRoomSearch.Items.Add(roomNo);
            }
            comboRoomSearch.SelectedIndex = -1; // Đặt giá trị mặc định
        }
        private void comboRoomSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboRoomSearch.SelectedIndex != -1)
            {
                string selectedRoomNo = comboRoomSearch.SelectedItem.ToString();
                SearchStudentByRoom(selectedRoomNo);
            }
        }
        private void SearchStudentByRoom(string roomNo)
        {
            query = "SELECT * FROM newStudent WHERE roomNo = '" + roomNo + "'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        private void SearchStudent(string keyword)
        {
            // Tạo truy vấn SQL để tìm kiếm sinh viên dựa trên các trường thông tin và từ khóa gần giống nhất
            query = "SELECT * FROM newStudent WHERE ";
            query += "name LIKE '%" + keyword + "%' OR ";
            query += "mobile LIKE '%" + keyword + "%' OR ";
            query += "idproof LIKE '%" + keyword + "%' OR ";
            query += "fname LIKE '%" + keyword + "%' OR ";
            query += "mname LIKE '%" + keyword + "%' OR ";
            query += "email LIKE '%" + keyword + "%' OR ";
            query += "paddress LIKE '%" + keyword + "%' OR ";
            query += "college LIKE '%" + keyword + "%' OR ";
            query += "roomNo LIKE '%" + keyword + "%' OR ";
            query += "IdClass LIKE '%" + keyword + "%'";

            // Lấy dữ liệu từ cơ sở dữ liệu
            DataSet ds = fn.GetData(query);

            // Hiển thị kết quả trong DataGridView
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAddSinhVien_Click(object sender, EventArgs e)
        {
            Student nst = new Student();
            nst.Show();
        }

        private void btnXoaSinhVien_Click(object sender, EventArgs e)
        {

            if (guna2DataGridView1.SelectedRows.Count > 0)
            {

                if (guna2DataGridView1.SelectedRows.Count > 0)
                {
                    // Lấy chỉ số của hàng được chọn
                    int rowIndex = guna2DataGridView1.SelectedRows[0].Index;

                    // Lấy ID của sinh viên từ hàng được chọn (cột idproof, bạn có thể thay đổi theo cột phù hợp)
                    string studentID = guna2DataGridView1.Rows[rowIndex].Cells["idproof"].Value.ToString();

                    // Xác nhận xóa
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Xóa sinh viên khỏi cơ sở dữ liệu
                        query = $"DELETE FROM newStudent WHERE idproof = '{studentID}'";
                        fn.GetData(query);

                        // Xóa hàng được chọn khỏi DataGridView
                        guna2DataGridView1.Rows.RemoveAt(rowIndex);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sinh viên để xóa.");
                }
            }
        } 

        private void btnClearData_Click_1(object sender, EventArgs e)
        {
            comboRoomSearch.SelectedIndex = -1;
            Load_Sinhvien();
        }
    }
}
