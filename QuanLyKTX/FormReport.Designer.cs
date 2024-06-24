namespace QuanLyKTX
{
    partial class FormReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReport));
            this.btnReportEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnReportStudent = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnReportEmployee
            // 
            this.btnReportEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnReportEmployee.BorderRadius = 15;
            this.btnReportEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnReportEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReportEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReportEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReportEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReportEmployee.FillColor = System.Drawing.Color.Red;
            this.btnReportEmployee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnReportEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnReportEmployee.Image")));
            this.btnReportEmployee.Location = new System.Drawing.Point(116, 370);
            this.btnReportEmployee.Name = "btnReportEmployee";
            this.btnReportEmployee.Size = new System.Drawing.Size(159, 45);
            this.btnReportEmployee.TabIndex = 11;
            this.btnReportEmployee.Text = "ReportNhanVien";
            this.btnReportEmployee.Click += new System.EventHandler(this.btnReportEmployee_Click);
            // 
            // btnReportStudent
            // 
            this.btnReportStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnReportStudent.BorderRadius = 15;
            this.btnReportStudent.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnReportStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReportStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReportStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReportStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReportStudent.FillColor = System.Drawing.Color.Red;
            this.btnReportStudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportStudent.ForeColor = System.Drawing.Color.Black;
            this.btnReportStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnReportStudent.Image")));
            this.btnReportStudent.Location = new System.Drawing.Point(485, 370);
            this.btnReportStudent.Name = "btnReportStudent";
            this.btnReportStudent.Size = new System.Drawing.Size(159, 45);
            this.btnReportStudent.TabIndex = 10;
            this.btnReportStudent.Text = "ReportSinhVien";
            this.btnReportStudent.Click += new System.EventHandler(this.btnReportStudent_Click);
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReportEmployee);
            this.Controls.Add(this.btnReportStudent);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnReportEmployee;
        private Guna.UI2.WinForms.Guna2Button btnReportStudent;
    }
}