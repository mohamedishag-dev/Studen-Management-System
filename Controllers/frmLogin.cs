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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private bool ShowPassword = false;

        private void frmLogin_Load(object sender, EventArgs e)
        {

            Image img = Properties.Resources.sign_in;
            btnLogin.Image = new Bitmap(img, new Size(24, 24));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtUserName.Text == "Admin" && txtPassword.Text == "1234")
                {

                    Form frmMessage = new frmMessage("Login Successfully");
                    frmMessage.ShowDialog();

                    txtUserName.Text = "" ;
                    txtPassword.Text = "";

                    Form Dashboard = new frmDashboard();
                    this.Hide();
                    Dashboard.ShowDialog();
                    this.Show();

                }

                else
                {
                    Form frmMessage = new frmMessage("The password you entered is incorrect");
                    frmMessage.ShowDialog();
                }


            }

            catch (Exception ex)
            {

                Form frmMessage = new frmMessage(ex.Message);
                frmMessage.ShowDialog();
            }
        }

        private void pEyeIcon_Click(object sender, EventArgs e)
        {

            if (!ShowPassword)
            {
                txtPassword.UseSystemPasswordChar = false;
                pEyeIcon.Image = Properties.Resources.eye_hide;
                ShowPassword = true;
            }

            else
            {
                txtPassword.UseSystemPasswordChar = true;
                pEyeIcon.Image = Properties.Resources.Eye_show;
                ShowPassword = false;
            }

        }

    }
}
