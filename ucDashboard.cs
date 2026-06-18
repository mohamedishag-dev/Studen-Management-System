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
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            dgvStudent.Rows.Clear();
            clsStudent.LoadStudentsDataFromFile(dgvStudent);
            lblTotalStudents.Text = clsStudent.Total().ToString();
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            clsStudent.LoadStudentsDataFromFile(dgvStudent, false);
            lblTotalStudents.Text = clsStudent.Total().ToString();

        }
    }

}
