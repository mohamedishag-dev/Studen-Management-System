using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Student_Management_System
{
    public class clsUser
    {
        public string FullName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Role { get; set; } = "User";
        public bool IsActive { get; set; } = true;
        public clsUser(string fullName, string username, string password, string role, bool isActive)
        {
            FullName = fullName;
            Username = username;
            PasswordHash = password;
            Role = role;
            IsActive = isActive;
        }
        public clsUser()
        {
            FullName = null;
            Username = null;
            PasswordHash = null;
            Role = null;
            IsActive = false;
        }

    }
}
