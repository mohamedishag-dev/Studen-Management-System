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
    public partial class ucAddStudent : UserControl
    {
        public ucAddStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgvFillData(DatabasePath);

        }

        private string DatabasePath = Application.StartupPath + @"\Database.txt";
        public void dgvFillData(string database)
        {

            string Sepretoer = "#//#";
            string FullName = txtFirstName.Text + " " + txtLastName.Text;
            string Age = txtAge.Text;
            string Phone = txtPhone.Text;
            string Gender = cbGender.Text;
            string Address = txtAddress.Text;

            bool SaveState = true;

            if (string.IsNullOrEmpty(FullName) || string.IsNullOrEmpty(Age) || string.IsNullOrEmpty(Phone)
                || string.IsNullOrEmpty(Gender) || string.IsNullOrEmpty(Address))
            {

                Form frmError = new frmMessage("Fill in the voids");

            }
            else
            {

                StreamReader Sr = new StreamReader(database);
                string reLine;

                int ID = 0;

                do
                {
                    reLine = Sr.ReadLine();

                    if (reLine != null)
                    {

                        string[] LineData = reLine.Split(new string[] { Sepretoer }, StringSplitOptions.None);

                        if (LineData[1] == txtFirstName.Text || LineData[2] == txtLastName.Text ||
                             LineData[3] == txtPhone.Text)
                        {
                            SaveState = false;
                        }

                    }
                    ID++;
                }
                while (reLine != null);
                Sr.Close();

                if (SaveState)
                {
                    StreamWriter SW = new StreamWriter(database, true);
                    SW.WriteLine(ID.ToString() + Sepretoer + FullName + Sepretoer + Age + Sepretoer + Phone + Sepretoer + Gender + Sepretoer + Address);
                    Form frmError = new frmMessage("Adding Successfully");
                    SW.Close();
                }
                else
                {
                    Form frmError = new frmMessage("Fill in the voids");

                }

            }


        }

      
    }
}
