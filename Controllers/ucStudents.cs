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
        }

        private void ucStudents_Load(object sender, EventArgs e)
        {
            //dgvStudents.Rows.Clear();

            //var students = clsStudent.LoadStudents();

            //foreach (var student in students)
            //{
            //    dgvStudents.Rows.Add(StudentService.GetStudent(student));
            //}

           // lblTotalStudents.Text = students.Count.ToString();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            //if (!string.IsNullOrWhiteSpace(txtIDSearch.Text))
            //{
            //    clsStudent Student = clsStudent.Find(txtIDSearch.Text);
            //    dgvStudents.Rows.Clear();
            //    dgvStudents.Rows.Add(StudentService.GetStudent(Student));
                
            //}
            //else
            //{
            //    MessageBox.Show("NO Find ID");
            //}

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvStudents.Rows.Clear();

            StudentService studentService = new StudentService();

            List<clsStudent> students = studentService.GetAll();


            foreach (var item in students)
            {
                if (dgvStudents.Rows.Count == 5)
                {
                    break;
                }
                dgvStudents.Rows.Add(item);
            }
 
            txtIDSearch.Text = string.Empty;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string StudentID = dgvStudents.CurrentRow.Cells[0].Value.ToString();

            
            //if (MessageBox.Show("Are your delete this Student " + StudentID, "", MessageBoxButtons.YesNo, 
            //    MessageBoxIcon.Asterisk) == DialogResult.Yes) 
            //{
            //    clsStudent.DeleteStudent(StudentID);

            //    dgvStudents.Rows.Clear();

            //    List<clsStudent> students = clsStudent.LoadStudents();

            //    foreach (var item in students)
            //    {
            //        dgvStudents.Rows.Add(StudentService.GetStudent(item));

            //    }
            //    txtIDSearch.Text = string.Empty;
            //}

        }

        private void btnEidt_Click(object sender, EventArgs e)
        {
            //clsStudent StudentEdit = clsStudent.Find(txtIDSearch.Text);

            //string StudentID = dgvStudents.CurrentRow.Cells[0].Value.ToString();
            //StudentService studentService = new StudentService();
            //if (StudentEdit.ID != "")
            //{
            //    frmEditStudent EditStudent = new frmEditStudent(StudentID);

            // //   if (studentService.IsExit(txtIDSearch.Text))
            //    {
            //        EditStudent = new frmEditStudent(txtIDSearch.Text);
            //    }
            // //   else
            //    {
            //        EditStudent = new frmEditStudent(StudentID);

            //    }
                
            //    EditStudent.ShowDialog();
            
            //}
            //else
            //{
            //    MessageBox.Show("Please Enter your ID","",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            //}


        }


    }
}