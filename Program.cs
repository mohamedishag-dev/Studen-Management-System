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

            //StudentService StudentS = new StudentService();

            //clsStudent student = StudentS.GetByUsername("STU013");

            //student.FirstName = "FirstName";
            //student.LastName = "LastName";
            //student.Address = "B303";

            //StudentS.Update(student);

            //Console.WriteLine(student.ID);
            //Console.WriteLine(student.FirstName + " " + student.FirstName);
            //Console.WriteLine(student.Gender);



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());

        }
    }
}
