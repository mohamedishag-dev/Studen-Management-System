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
        }

        private void ucStudents_Load(object sender, EventArgs e)
        {

            List<clsStudent> students = clsStudent.LoadStudents();
            short Conu = 0;

            foreach (var item in students)
            {
                dgvStudents.Rows.Add(clsStudent.StudentSearch(item));
                Conu++;

            }
            lblTotalStudents.Text = Conu.ToString();

            Image imgEidt = Properties.Resources.edit_24;
            btnEidt.Image = new Bitmap(imgEidt, new Size(24, 24));

            Image imgDelete = Properties.Resources.delete;
            btnDelete.Image = new Bitmap(imgDelete, new Size(24, 24));

            Image imgRefresh = Properties.Resources.Refresh;
            btnRefresh.Image = new Bitmap(imgRefresh, new Size(24, 24));

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtIDSearch.Text))
            {
                clsStudent Student = clsStudent.Find(txtIDSearch.Text);
                dgvStudents.Rows.Clear();
                dgvStudents.Rows.Add(clsStudent.StudentSearch(Student));
                
            }
            else
            {
                MessageBox.Show("NO Find ID");
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvStudents.Rows.Clear();

            List<clsStudent> students = clsStudent.LoadStudents();

            foreach (var item in students)
            {
                dgvStudents.Rows.Add(clsStudent.StudentSearch(item));

            }
            txtIDSearch.Text = string.Empty;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string StudentID = dgvStudents.CurrentRow.Cells[0].Value.ToString();

            
            if (MessageBox.Show("Are your delete this Student " + StudentID, "", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Asterisk) == DialogResult.Yes) 
            {
                clsStudent.DeleteStudent(StudentID);

                dgvStudents.Rows.Clear();

                List<clsStudent> students = clsStudent.LoadStudents();

                foreach (var item in students)
                {
                    dgvStudents.Rows.Add(clsStudent.StudentSearch(item));

                }
                txtIDSearch.Text = string.Empty;
            }

        }

        private void btnEidt_Click(object sender, EventArgs e)
        {
            clsStudent StudentEdit = clsStudent.Find(txtIDSearch.Text);

            if (StudentEdit.ID != "")
            {

                frmEditStudent EditStudent = new frmEditStudent(txtIDSearch.Text);
                EditStudent.ShowDialog();
            
            }
            else
            {
                MessageBox.Show("Please Enter your ID","",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }


        }

    }
}