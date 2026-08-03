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
            StudentGridHelper.StudentToRows(dgvStudent);
            lblTotalStudents.Text = dgvStudent.RowCount.ToString();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            StudentGridHelper.StudentToRows(dgvStudent);
            lblTotalStudents.Text = dgvStudent.RowCount.ToString();

        }


    }

}
