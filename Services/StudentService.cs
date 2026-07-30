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

        private static string UsersFile = Application.StartupPath + @"\students.txt";
        private static string Seperator = "#//#";

        private static clsStudent ConvertRecordToStudentObject(string Line)
        {
            string[] DataLine =
                Line.Split(new string[] { Seperator },
                StringSplitOptions.None);

            return new clsStudent(
                DataLine[0],
                DataLine[1],
                DataLine[2],
                Convert.ToInt32(DataLine[3]),
                DataLine[4],
                DataLine[5],
                DataLine[6]
            );
        }

        private static string ConverStudentObjectToRecord(clsStudent Student)
        {

            string StudentRecord = "";
            StudentRecord = Student.ID + Seperator;
            StudentRecord += Student.FirstName + Seperator;
            StudentRecord += Student.LastName + Seperator;
            StudentRecord += Student.Age.ToString() + Seperator;
            StudentRecord += Student.Phone + Seperator;
            StudentRecord += Student.Gender + Seperator;
            StudentRecord += Student.Address;
            return StudentRecord;

        }

        private static void ChangeDate(List<clsStudent> Users)
        {

            System.IO.File.WriteAllText(Constants.StudentsFile, "");

            foreach (clsStudent User in Users)
            {

                using (StreamWriter reDatabase = new StreamWriter(Constants.StudentsFile, true))
                {

                    reDatabase.WriteLine(ConverStudentObjectToRecord(User));

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

        public clsStudent GetByUsername(string Username)
        {
            List<clsStudent> Students = GetAll();

            foreach (clsStudent item in Students)
            {

                if (item.ID == Username)
                {

                    return item;

                }
            }

            return new clsStudent();

        }

        public void Add(clsStudent record)
        {

            using (StreamWriter reDatabase = new StreamWriter(Constants.StudentsFile, true))
            {

                reDatabase.WriteLine(ConverStudentObjectToRecord(record));

            }

        }

        public void Update(clsStudent record)
        {

            List<clsStudent> Students = GetAll();

            for (int item = 0; item < Students.Count; item++)
            {
                if (Students[item].ID == record.ID)
                {
                    Students[item] = record;
                    break;
                }
            }

            ChangeDate(Students);

        }

        public void Delete(clsStudent record)
        {
            List<clsStudent> Students = GetAll();

            foreach (clsStudent User in Students)
            {

                if (User.ID == record.ID)
                {
                    Students.Remove(User);
                    break;
                }

            }

            ChangeDate(Students);
        }

    }
}
