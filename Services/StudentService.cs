using Student_Management_System.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System.Services
{
    internal class StudentService : IGenericService<clsStudent>
    {
        private string CreateID()
        {
            List<clsStudent> Students = GetAll();

            if (Students.Count == 0)
                return "STU001";

            else
            {
                
                int Number = Convert.ToInt32(Students[Students.Count - 1].ID.Substring(3));

                Number++;
                if (Number <= 9)
                    return "STU00" + Number;
                else if (Number <= 99)
                    return "STU0" + Number;
                else
                    return "STU" + Number;
            }

        }

        private static bool IsValid(clsStudent Student)
        {
            
            return !string.IsNullOrWhiteSpace(Student.FirstName)
                && !string.IsNullOrWhiteSpace(Student.LastName)
                && Student.BirthDate != DateTime.MinValue
                && Student.BirthDate > DateTime.Now.AddYears(-120)
                && !string.IsNullOrWhiteSpace(Student.Phone)
                && !string.IsNullOrWhiteSpace(Student.Gender)
                && !string.IsNullOrWhiteSpace(Student.Address);
        }

        StudentRepository repository = new StudentRepository();

        public List<clsStudent> GetAll()
        {
            
            return repository.GetAll();

        }

        public clsStudent Find(string username)
        {
            List<clsStudent> Students = GetAll();

            foreach (clsStudent item in Students)
            {
                if (item.ID == username)
                {
                    return item;
                }
            }
            return new clsStudent();
        }

        public bool Add(clsStudent studnet)
        {
            
            if (repository.Exists(studnet.ID))
                return false;

            if (IsValid(studnet))
            {
                if (string.IsNullOrWhiteSpace(studnet.ID))
                    studnet.ID = CreateID();

                repository.Add(studnet);
                return true;

            }
            return false;
        }

        public bool Update(clsStudent studnet)
        {
            if (!repository.Exists(studnet.ID))
                return false;

            if (IsValid(studnet))
            {
               
                repository.Update(studnet);
                return true;

            }

            return false;

        }

        public bool Delete(string id)
        {
            if (!repository.Exists(id))
                return false;

            repository.Delete(id);
            return true;
        }

        public bool Exists(string id)
        {
            if (repository.Exists(id))
                return true;

            return false;
        }
    }
}
