using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            clsStudent.LoadStudentsDataFromFile(dgvStudents);

            Image imgEidt = Properties.Resources.edit_24;
            btnEidt.Image = new Bitmap(imgEidt, new Size(24, 24));

            Image imgDelete = Properties.Resources.delete;
            btnDelete.Image = new Bitmap(imgDelete, new Size(24, 24));

            Image imgRefresh = Properties.Resources.Refresh;
            btnRefresh.Image = new Bitmap(imgRefresh, new Size(24, 24));

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clsStudent Student = clsStudent.Find(txtIDSearch.Text);

            if (Student.Age != 0)
            {
         

                dgvStudents.Rows.Clear();
                clsStudent.StudentCard(dgvStudents, Student);
            }
            else
            {
                MessageBox.Show("NO Find ID");
               
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvStudents.Rows.Clear();
            clsStudent.LoadStudentsDataFromFile(dgvStudents);
            txtIDSearch.Text = string.Empty;
        }

      

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string StudentID = dgvStudents.CurrentRow.Cells[0].Value.ToString();

            clsStudent.DeleteStudent(StudentID);

        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


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