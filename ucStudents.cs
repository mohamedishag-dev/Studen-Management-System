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

namespace Student_Management_System
{
    public partial class ucStudents : UserControl
    {
        public ucStudents()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            for (int i = 1; i <= 20; i++)
            {

                string[] DataLine = { i.ToString(), "Mohamed Ishag", "21",  "09267226354", "Male", "B303" };
                dgvStudents.Rows.Add(DataLine);

            }

        }

        private void ucStudents_Load(object sender, EventArgs e)
        {
            if (!File.Exists(DatabasePath))
            {
                File.Create(DatabasePath);
            }

            dgvFillData(DatabasePath, dgvStudents);

        }
        string DatabasePath = Application.StartupPath + @"\Database.txt";

        private void qucStudents_Load(object sender, EventArgs e)
        {
            if (!File.Exists(DatabasePath))
            {
                File.Create(DatabasePath);
            }

            dgvFillData(DatabasePath, dgvStudents);

        }

        public static void dgvFillData(string database, DataGridView dgvDatabase)
        {

            try
            {
                StreamReader reDatabase = new StreamReader(database);
                string reLine;

                do
                {
                    reLine = reDatabase.ReadLine();

                    if (reLine != null)
                    {
                        object[] dataLine = reLine.Split(new string[] { "#//#" }, StringSplitOptions.None);
                        dgvDatabase.Rows.Add(dataLine);

                    }
                }
                while (reLine != null);
                reDatabase.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }

        }

    }
}
