using Student_Management_System.Controllers;
using Student_Management_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();

            List<clsStudent> students = studentService.GetAll();

            foreach (var item in students)
            {
                if (dgvStudent.Rows.Count == 5)
                {
                    break;
                }

                dgvStudent.Rows.Add(StudentUI.StudentToRow(item));
            }
            lblTotalStudents.Text = 5.ToString();

        }
        private StudentService studentService = new StudentService();
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            dgvStudent.Rows.Clear();
           
            List<clsStudent> students = studentService.GetAll();
            
            foreach (var item in students)
            {
                dgvStudent.Rows.Add(item);
            }
            lblTotalStudents.Text = students.Count.ToString();

        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            //dgvStudent.Rows.Clear();

            //StudentService studentService = new StudentService();

            //List<clsStudent> students = studentService.GetAll();


            //foreach (var item in students)
            //{
            //    if (dgvStudent.Rows.Count == 5)
            //    {
            //        break;
            //    }
            //    dgvStudent.Rows.Add(StudentService.GetStudent(item));
            //}
            //lblTotalStudents.Text = 5.ToString();

        }
    }

}
