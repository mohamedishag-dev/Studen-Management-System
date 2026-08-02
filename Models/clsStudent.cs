using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Management_System
{
    public class clsStudent
    {

        public string ID { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    
        public clsStudent()
        {
            ID = null;
            FirstName = null;
            LastName = null;
            BirthDate = DateTime.MinValue;
            Phone = null;
            Gender = null;
            Address = null;
        }

        public clsStudent(string iD, string firstName, string lastName, DateTime birthdate,
            string phone, string gender, string address)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthdate;
            Gender = gender;
            Phone = phone;
            Address = address;
        }
       
    }

}   