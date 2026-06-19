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

            List<clsStudent> students = clsStudent.LoadStudents();
            short Conu = 0;

            foreach (var item in students)
            {
                dgvStudent.Rows.Add(clsStudent.StudentSearch(item));
                Conu++;
            }
            lblTotalStudents.Text = Conu.ToString();

        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {

            List<clsStudent> students = clsStudent.LoadStudents();
            short Conu = 0;

            foreach (var item in students)
            {
                if (Conu == 5) 
                {
                    break;
                }
                dgvStudent.Rows.Add(clsStudent.StudentSearch(item));
                Conu++;
            }

            lblTotalStudents.Text = Conu.ToString();


        }
    }

}
