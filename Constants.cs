using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public static class Constants
    {
        public const string Separator = "#//#";

        public static string StudentsFile = Application.StartupPath + @"\students.txt";

        public static string UsersFile = Application.StartupPath + @"\users.txt";

    }

}
