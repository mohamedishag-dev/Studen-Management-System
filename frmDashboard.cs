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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }


        private Color DefaultColor = Color.FromArgb(39, 41, 59);
        private Panel pnlActivate;
        private void ResetBackColor(Panel Pnl)
        {
            pnlDashboard.BackColor = DefaultColor;
            pnlStudents.BackColor = DefaultColor;
            pnlAddStudent.BackColor = DefaultColor;
            pnlUser.BackColor = DefaultColor;
            
            Pnl.BackColor = Color.FromArgb(37, 99, 235);
            pnlActivate = Pnl;
        }

        private void Pnl_MouseEnter(Panel Pnl)
        {
            Pnl.BackColor = Color.FromArgb(37, 99, 235);
        }

        private void Pnl_MouseLeave(Panel Pnl)
        {
            if (Pnl == pnlActivate)
                return;
            else
                Pnl.BackColor = DefaultColor;
        }

        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            Pnl_MouseEnter(pnlDashboard);
        }
        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            Pnl_MouseLeave(pnlDashboard);

        }

        private void btnStudents_MouseEnter(object sender, EventArgs e)
        {
            Pnl_MouseEnter(pnlStudents);

        }

        private void btnStudents_MouseLeave(object sender, EventArgs e)
        {
            Pnl_MouseLeave(pnlStudents);

        }

        private void btnUser_MouseLeave(object sender, EventArgs e)
        {
            Pnl_MouseLeave(pnlUser);

        }

        private void btnUser_MouseEnter(object sender, EventArgs e)
        {
            Pnl_MouseEnter(pnlUser);

        }

        private void btnAddStudent_MouseEnter(object sender, EventArgs e)
        {
            Pnl_MouseEnter(pnlAddStudent);

        }

        private void btnAddStudent_MouseLeave(object sender, EventArgs e)
        {
            Pnl_MouseLeave(pnlAddStudent);

        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {

            Pnl_MouseEnter(pnlLogout);

        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {

            Pnl_MouseLeave(pnlLogout);

        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            ResetBackColor(pnlStudents);
            panelContainer.Controls.Clear();

            ucStudents students = new ucStudents();

            students.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(students);

        }

        // Sign out Button 
        private void btnLogout_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            ResetBackColor(pnlAddStudent);

            panelContainer.Controls.Clear();
            ucAddStudent AddStudent = new ucAddStudent();
            AddStudent.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(AddStudent);

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ResetBackColor(pnlUser);

            panelContainer.Controls.Clear();
            ucUsers Users = new ucUsers();
            Users.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(Users);

        }
        
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            ResetBackColor(pnlDashboard);

            panelContainer.Controls.Clear();
            ucDashboard Dashboard = new ucDashboard();
            Dashboard.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(Dashboard);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ResetBackColor(pnlDashboard);

            panelContainer.Controls.Clear();
            ucDashboard Dashboard = new ucDashboard();
            Dashboard.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(Dashboard);
        }

      

    }
}