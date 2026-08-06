using Student_Management_System.Controllers;
using Student_Management_System.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class ucStudents : UserControl
    {

        public ucStudents()
        {
            InitializeComponent();

            Image imgEidt = Properties.Resources.edit_24;
            btnEidt.Image = new Bitmap(imgEidt, new Size(24, 24));

            Image imgDelete = Properties.Resources.delete;
            btnDelete.Image = new Bitmap(imgDelete, new Size(24, 24));

            Image imgRefresh = Properties.Resources.Refresh;
            btnRefresh.Image = new Bitmap(imgRefresh, new Size(24, 24));

            StudentGridHelper.StudentToRows(dgvStudent);
            lblTotalStudents.Text = dgvStudent.RowCount.ToString();

        }

        private static StudentService service = new StudentService();
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtIDSearch.Text;

            if (!string.IsNullOrWhiteSpace(id))
            {
                if (service.Exists(id))
                {
                    StudentGridHelper.GetStudent(dgvStudent, id);                  
                }
                else
                {
                    MessageBox.Show("NO Find ID");
                }
            }
            else
            {
                MessageBox.Show("The Text Search Is Null Or White Space?");
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtIDSearch.Text = string.Empty;
            StudentGridHelper.StudentToRows(dgvStudent);
            lblTotalStudents.Text = dgvStudent.RowCount.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string StudentID = dgvStudent.CurrentRow.Cells[0].Value.ToString();

            if (MessageBox.Show("Are your delete this Student " + StudentID, "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                if (service.Delete(StudentID))
                {
                    StudentGridHelper.StudentToRows(dgvStudent);
                    lblTotalStudents.Text = dgvStudent.RowCount.ToString();
                    MessageBox.Show("Successfully deleted this Student " + StudentID, "Successfully");
                }
            }

        }

        private void btnEidt_Click(object sender, EventArgs e)
        {
            string StudentID = dgvStudent.CurrentRow.Cells[0].Value.ToString();

            if (!string.IsNullOrWhiteSpace(StudentID))
            {
                frmEditStudent EditStudent = new frmEditStudent(StudentID);
                EditStudent.ShowDialog();
                btnRefresh_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please Enter your ID", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }


        }

       
    }
}