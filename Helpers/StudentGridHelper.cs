using Student_Management_System.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System.Controllers
{
    public class StudentGridHelper
    {

        private static StudentService service = new StudentService();

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

        public static void GetStudent(DataGridView dgv, string id)
        {           
            if (service.Exists(id))
            {
                dgv.Rows.Clear();
                clsStudent student = service.Find(id);
                dgv.Rows.Add(StudentToRow(student));
            }
                      
        }

        public static void StudentToRows(DataGridView dgv)
        {
            dgv.Rows.Clear();
            List<clsStudent> Students = service.GetAll();

            foreach (var student in Students)
            {
                dgv.Rows.Add(StudentToRow(student));
            }

        }
    }
}
