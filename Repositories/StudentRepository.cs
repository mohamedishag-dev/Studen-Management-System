using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Student_Management_System.Repositories
{
    public class StudentRepository : IGenericRepository<clsStudent>
    {
        private clsStudent ConvertRecordToStudentObject(string record)
        {
            string[] data =
                record.Split(new string[] { Constants.Separator },
                StringSplitOptions.None);

            if (data.Length != 7)
            {
                return null;
            }

            return new clsStudent(
                data[0],
                data[1],
                data[2],
                Convert.ToDateTime(data[3]),
               // DateTime.Parse(data[3]),
                data[4],
                data[5],
                data[6]
            );
        }
        private static string ConverStudentObjectToLine(clsStudent student)
        {

            string record = "";
            record = student.ID + Constants.Separator;
            record += student.FirstName + Constants.Separator;
            record += student.LastName + Constants.Separator;
            record += student.BirthDate.ToString("dd/MM/yyyy") + Constants.Separator;
            record += student.Phone + Constants.Separator;
            record += student.Gender + Constants.Separator;
            record += student.Address;
            return record;

        }
        private static void SaveStudents(List<clsStudent> Students)
        {

            System.IO.File.WriteAllText(Constants.StudentsFile, "");

            using (StreamWriter reDatabase = new StreamWriter(Constants.StudentsFile, true))
            {
                foreach (var item in Students)
                {
                    reDatabase.WriteLine(ConverStudentObjectToLine(item));
                }
            }

        }

        public List<clsStudent> GetAll()
        {
            List<clsStudent> Students = new List<clsStudent>();

            using (StreamReader reDatabase = new StreamReader(Constants.StudentsFile))
            {
                string record;
                do
                {
                    record = reDatabase.ReadLine();

                    if (record != null)
                    {
                        Students.Add(ConvertRecordToStudentObject(record));
                    }

                }
                while (record != null);
            }
            return Students;
        }

        public clsStudent Find(string id)
        {
            List<clsStudent> Students = GetAll();

            foreach (var item in Students)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public void Add(clsStudent student)
        {

            using (StreamWriter reDatabase = new StreamWriter(Constants.StudentsFile, true))
            {
                reDatabase.WriteLine(ConverStudentObjectToLine(student));
            }

        }

        public void Update(clsStudent student)
        {

            List<clsStudent> Students = GetAll();

            for (int item = 0; item < Students.Count; item++)
            {
                if (Students[item].ID == student.ID)
                {
                    Students[item] = student;
                    break;
                }
            }
            SaveStudents(Students);
        }

        public void Delete(string id)
        {

            List<clsStudent> Students = GetAll();

            foreach (clsStudent student in Students)
            {

                if (student.ID == id)
                {
                    Students.Remove(student);
                    break;
                }

            }
            SaveStudents(Students);
        }

        public bool Exists(string id)
        {
            List<clsStudent> Users = GetAll();

            foreach (clsStudent item in Users)
            {
                if (item.ID == id)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
