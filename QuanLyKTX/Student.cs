using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyKTX
{
    public partial class Student : Form
    {
        function fn = new function();
        String query;
        public Student()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private Dictionary<string, string> collegeDictionary = new Dictionary<string, string>();
        private void Student_Load(object sender, EventArgs e)
        {
            this.Location = new Point(450, 131);
            query = "SELECT roomNo from room";

            DataSet ds = fn.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                comboRoomNo.Items.Add(room);
            }

            query = "SELECT IDClass, College FROM College";
            ds = fn.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string idClass = ds.Tables[0].Rows[i]["IDClass"].ToString();
                string collegeName = ds.Tables[0].Rows[i]["College"].ToString();

                // Add collegeName to comboClass and idClass to comboIdClass
                comboClass.Items.Add(collegeName);
                comboIdClass.Items.Add(idClass);

                // Store the mapping in the dictionary
                collegeDictionary[collegeName] = idClass;
            }
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtFName.Clear();
            txtMName.Clear();
            txtEmail.Clear();
            txtIdProof.Clear();
            txtAddress.Clear();
            comboClass.SelectedIndex = -1;
            comboIdClass.SelectedIndex = -1;
            comboRoomNo.SelectedIndex = -1;
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "" && txtName.Text != "" && txtAddress.Text != "" && comboClass.SelectedIndex != -1 && txtIdProof.Text != "" && comboRoomNo.SelectedIndex != -1)
            {
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String Name = txtName.Text;
                String FName = txtFName.Text;
                String MName = txtMName.Text;
                String email = txtEmail.Text;
                String CCCD = txtIdProof.Text;
                String collegeName = comboClass.SelectedItem.ToString(); 
                String Diachi = txtAddress.Text;

                
                String idClass = comboIdClass.SelectedItem.ToString(); 

                Int64 roomNo = Int64.Parse(comboRoomNo.Text);

                query = "Insert into newStudent(mobile, name, fname, mname, email, paddress, college, idproof, IdClass , roomNo) " +
                        $"values ({mobile}, '{Name}', '{FName}', '{MName}', '{email}', '{CCCD}', '{collegeName}', '{Diachi}', '{idClass}', {roomNo}); " +
                        $"update room set Booked = 'Yes' WHERE roomNo = {roomNo}";
                fn.setData(query, "Sinh viên đã đăng ký thành công.");

                clearAll();
            }
            else
            {
                MessageBox.Show("Xin vui lòng điền đầy đủ thông tin", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void txtIdProof_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboClass.SelectedIndex != -1)
            {
                
                Console.WriteLine($"Selected item: {comboClass.SelectedItem.ToString()}");

                
                if (Int64.TryParse(comboClass.SelectedItem.ToString(), out Int64 selectedClass))
                {
                    
                    query = "SELECT CollegeName FROM College WHERE IDClass = " + selectedClass;

                    DataSet ds = fn.GetData(query);
                    comboRoomNo.Items.Clear();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        
                        if (Int64.TryParse(ds.Tables[0].Rows[i][0].ToString(), out Int64 room))
                        {
                            comboRoomNo.Items.Add(room);
                        }
                        else
                        {
                            
                            Console.WriteLine($"Failed to parse room number: {ds.Tables[0].Rows[i][0].ToString()}");
                        }
                    }
                }
                else
                {
                    
                    Console.WriteLine($"Failed to parse selectedClass: {comboClass.SelectedItem.ToString()}");
                }
            }
        }
        
    }
   
}
