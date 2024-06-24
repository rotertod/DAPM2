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
    public partial class ThongKeEmployee : Form
    {
        function fn = new function();
        String query;

        public ThongKeEmployee()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                
                string connectionString = "Data Source=DESKTOP-PBM8R65;Initial Catalog=hostel;Integrated Security=hostel;Integrated Security = True; database = hostel; Integrated Security = True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                   
                    connection.Open();

                    
                    string sql = "SELECT id,ename,eidproof,working FROM newEmployee";

                    
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                   
                    DataTable dataTable = new DataTable();

                   
                    adapter.Fill(dataTable);

                    
                    if (dataTable.Rows.Count > 0)
                    {
                        
                        rptKTX report = new rptKTX();

                       
                        report.SetDataSource(dataTable);

                        
                        crystalReportViewer1.ReportSource = report;
                        crystalReportViewer1.Refresh();
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
    }
}
