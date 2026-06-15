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

        private void LoadData()
        {


            for (int i = 1; i <= 20; i++)
            {
                string[] DataLine = { i.ToString(), "Mohamed Ishag", "21", "Male", "09267226354", "B303" };

                dgv1.Rows.Add((DataLine));

            }

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            LoadData();
        }
    }
}
