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
    public partial class frmEditStudent : Form
    {
        public frmEditStudent(string ID)
        {
            InitializeComponent();

             StudentEdit = clsStudent.Find(ID);


        }
        clsStudent StudentEdit;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditStudent_Load(object sender, EventArgs e)
        {
            Image imgEidt = Properties.Resources.save_edit;
            btnUpdata.Image = new Bitmap(imgEidt, new Size(24, 24));
            Image imgCancel = Properties.Resources.close;
            btnCancel.Image = new Bitmap(imgCancel, new Size(24, 24));

            lblIDStudent.Text = StudentEdit.ID;
            txtFirstName.Text = StudentEdit.FirstName;
            txtLastName.Text = StudentEdit.LastName;
            txtAge.Text = StudentEdit.Age.ToString();
            txtPhone.Text = StudentEdit.Phone;
            cbGender.Text = StudentEdit.Gender;
            txtAddress.Text = StudentEdit.Address;

        }

        private void btnUpdata_Click(object sender, EventArgs e)
        {

        }
    }
}
