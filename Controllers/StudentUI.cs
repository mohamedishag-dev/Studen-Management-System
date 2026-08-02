using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Controllers
{
    public class StudentUI
    {
        public static object[] StudentToRow(clsStudent student)
        {
            return new object[]
            {
        student.ID,
        student.FirstName,
        student.LastName,
        student.BirthDate.ToShortDateString(),
        student.Phone,
        student.Gender,
        student.Address
            };
        }
    }
}
