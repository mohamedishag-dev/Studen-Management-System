using Student_Management_System.Repositories;
using Student_Management_System.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //  ucDashboard dashboard = new ucDashboard();
            //  dashboard.Show();
            //  StudentRepository Repository = new StudentRepository();
            //  StudentService service = new StudentService();
            //  clsStudent student = new clsStudent();// "100", "first", "last", new DateTime(2005, 5, 10), "01927282727363", "male","D33");

            //  student.FirstName = "first";
            //  student.LastName = "last";
            //  student.BirthDate = Convert.ToDateTime("12/11/2004");
            //  student.Phone = "0192872723";
            //  student.Gender = "male";
            //  student.Address = "B303";
            ////  Repository.Add(student);
            //  service.Add(student);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLogin());
            Application.Run(new frmDashboard());

        }
    }
}
