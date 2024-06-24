using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class ThongKeStudent : Form
    {
        function fn = new function();
        String query;
        public ThongKeStudent()
        {
            InitializeComponent();
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {
            try
            {
                // Tạo kết nối tới cơ sở dữ liệu
                string connectionString = "Data Source=DESKTOP-PBM8R65;Initial Catalog=hostel;Integrated Security=hostel;Integrated Security = True; database = hostel; Integrated Security = True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Mở kết nối
                    connection.Open();

                    // Tạo câu lệnh SQL để lấy dữ liệu sinh viên
                    string sql = "SELECT id,mobile,name,fname,mname,email,paddress,college,idproof,roomNo,living,IdClass";

                    // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ cơ sở dữ liệu vào DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                    // Tạo DataTable để lưu trữ dữ liệu
                    DataTable dataTable = new DataTable();

                    // Đổ dữ liệu từ SqlDataAdapter vào DataTable
                    adapter.Fill(dataTable);

                    // Kiểm tra xem DataTable có dữ liệu hay không
                    if (dataTable.Rows.Count > 0)
                    {
                        // Tạo một đối tượng Crystal Report
                        rptStudents report = new rptStudents();

                        // Đổ dữ liệu từ DataTable vào Crystal Report
                        report.SetDataSource(dataTable);

                        // Hiển thị báo cáo trong CrystalReportViewer
                        crystalReportViewer2.ReportSource = report;
                        crystalReportViewer2.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThongKeStudent_Load(object sender, EventArgs e)
        {

        }

    }
}
