using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Xml;
using System.Data;

namespace QuanLyKTX
{
    internal class function
    {
        internal DataSet getData;

        protected SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-PBM8R65;Initial Catalog=hostel;Integrated Security=hostel;Integrated Security = True; database = hostel; Integrated Security = True";

            return con;
        }
        public DataSet GetData(String query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            dp.Fill(ds);
            return ds;
        }

        public void setData(String query, String msg)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            try
            {
                // Thực thi câu lệnh SQL
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi
                Console.WriteLine("SQL Exception: " + ex.Message);
            }
            
            con.Close();
            MessageBox.Show(msg, "THÔNG TIN", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }

}
