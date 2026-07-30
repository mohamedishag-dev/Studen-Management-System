using Student_Management_System.Repositories;
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


            clsUser User = new clsUser("Ali Ahmed", "User001", "1234", "Admin", true);

            UserService userService = new UserService();

            List<clsUser> Users =  userService.GetAll();

            foreach (var item in Users)
            {
                Console.WriteLine(User.FullName);
            }
            //userService.Add(User);

            //Console.WriteLine(User.FullName); // يجب أن تكون 8
            //Console.WriteLine(User.Username); // يجب أن تكون 8
            //Console.WriteLine(User.PasswordHash); // يجب أن تكون 8
            //Console.WriteLine(User.Role); // يجب أن تكون 8
            //Console.WriteLine(User.IsActive); // يجب أن تكون 8

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLogin());
        }
    }
}
