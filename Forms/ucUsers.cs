using Student_Management_System.Controllers;
using Student_Management_System.Repositories;
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
    public partial class ucUsers : UserControl
    {
        public ucUsers()
        {
            InitializeComponent();
            UserGridHelper.UserToRows(dgvUsers);
            lblTotalUsers.Text = dgvUsers.RowCount.ToString();

        }
        private static UserService service = new UserService();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string username = txtIDSearch.Text;

            if (!string.IsNullOrWhiteSpace(username))
            {
                if (service.Exists(username))
                {
                    UserGridHelper.GetUser(dgvUsers, username);
                }

                else
                {
                    MessageBox.Show("NO Find username");
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
            UserGridHelper.UserToRows(dgvUsers);
            lblTotalUsers.Text = dgvUsers.RowCount.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string username = dgvUsers.CurrentRow.Cells[1].Value.ToString();

            if (MessageBox.Show("Are your delete this User " + username, "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                if (service.Delete(username))
                {
                    UserGridHelper.UserToRows(dgvUsers);
                    lblTotalUsers.Text = dgvUsers.RowCount.ToString();
                    MessageBox.Show("Successfully deleted this User " + username, "Successfully");
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string passwordHash = txtPassword.Text;
            string Role = cbRole.Text;
            bool IsActive = Convert.ToBoolean(cbStatus.Created);
            clsUser user = new clsUser(1, username, passwordHash, Role, IsActive);

            if (user.PasswordHash == txtConfirmPassword.Text)
            {
                if (service.Add(user))
                {
                    MessageBox.Show("Adding Successfully", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    txtUserName.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    txtConfirmPassword.Text = string.Empty;

                }
                else
                {
                    MessageBox.Show("Fill in the voids", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            UserGridHelper.UserToRows(dgvUsers);
            lblTotalUsers.Text = dgvUsers.RowCount.ToString();
        }
 
    }

}
