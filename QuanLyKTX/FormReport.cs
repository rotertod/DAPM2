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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {

        }

        private void btnReportEmployee_Click(object sender, EventArgs e)
        {
            ThongKeEmployee yo = new ThongKeEmployee();
            yo.Show();
        }

        private void btnReportStudent_Click(object sender, EventArgs e)
        {
            ThongKeStudent vcl = new ThongKeStudent();
            vcl.Show();
        }
    }
}
