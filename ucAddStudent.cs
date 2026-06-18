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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Management_System
{
    public partial class ucAddStudent : UserControl
    {
        public ucAddStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            clsStudent Student = new clsStudent();

            Student.FirstName = txtFirstName.Text;
            Student.LastName = txtLastName.Text;
            Student.Age = Convert.ToInt32(txtAge.Text);
            Student.Phone = txtPhone.Text;
            Student.Gender = cbGender.Text;
            Student.Address = txtAddress.Text;
            
            if (clsStudent.AddDataLineToFile(Student))
            {
                MessageBox.Show("Adding Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtAge.Text = "";
                txtPhone.Text = "";
                txtAddress.Text = ""; 
            }
            else
            {
                MessageBox.Show("Fill in the voids", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

     
    }
}
