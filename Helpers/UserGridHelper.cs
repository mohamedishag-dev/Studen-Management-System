using Student_Management_System.Repositories;
using Student_Management_System.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    internal class UserGridHelper
    {

        private static UserService service = new UserService();

        public static object[] UserToRow(clsUser user)
        {
            return new object[]
            {
                user.ID,
                user.Username,
                user.Role,
                (user.IsActive==true)?"Active":"Inactive"
            };
        }

        public static void GetUser(DataGridView dgv, string user)
        {
            if (service.Exists(user))
            {
                dgv.Rows.Clear();
                clsUser student = service.Find(user);
                dgv.Rows.Add(UserToRow(student));
            }

        }

        public static void UserToRows(DataGridView dgv)
        {
            dgv.Rows.Clear();
            List<clsUser> Users = service.GetAll();

            foreach (var student in Users)
            {
                dgv.Rows.Add(UserToRow(student));
            }

        }

    }
}
