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
        public int ID { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public clsUser(int id, string username, string password, string role, bool isActive)
        {
            ID = id;
            Username = username;
            PasswordHash = password;
            Role = role;
            IsActive = isActive;
        }
      

    }
}
