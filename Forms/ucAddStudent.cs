using Student_Management_System.Services;
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
            Student.BirthDate = dtpBirthDate.Value;
            Student.Phone = txtPhone.Text;
            Student.Gender = cbGender.Text;
            Student.Address = txtAddress.Text;

            StudentService service = new StudentService();

            if (service.Add(Student)) 
            {
                MessageBox.Show("Adding Successfully", "Success",MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtAddress.Text = "";
                txtPhone.Text = "";

            }
            else
            {
                MessageBox.Show("Fill in the voids", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }
}
