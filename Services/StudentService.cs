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

        private static clsStudent ConvertRecordToStudentObject(string record)
        {
            string[] DataLine =
                record.Split(new string[] { Constants.Separator },
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
            StudentRecord = Student.ID + Constants.Separator;
            StudentRecord += Student.FirstName + Constants.Separator;
            StudentRecord += Student.LastName + Constants.Separator;
            StudentRecord += Student.Age.ToString() + Constants.Separator;
            StudentRecord += Student.Phone + Constants.Separator;
            StudentRecord += Student.Gender + Constants.Separator;
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

        private string CreateID()
        {

            List<clsStudent> Students = GetAll();

            if (Students.Count == 0)
            {

                return "STU001";
            }
            else
            {
                string LastStudent = Students[Students.Count - 1].ID;
                int Number = Convert.ToInt32(LastStudent.Substring(3));

                Number++;
                if (Number <= 9)
                    return "STU00" + Number;
                else if (Number <= 99)
                    return "STU0" + Number;
                else
                    return "STU" + Number;
            }

        }

        private static bool IsValidStudent(clsStudent Student)
        {
            return !string.IsNullOrWhiteSpace(Student.FirstName)
                && !string.IsNullOrWhiteSpace(Student.LastName)
                && Student.Age > 0
                && !string.IsNullOrWhiteSpace(Student.Phone)
                && !string.IsNullOrWhiteSpace(Student.Gender)
                && !string.IsNullOrWhiteSpace(Student.Address);
        }

        public static string[] GetStudent(clsStudent Student)
        {

            string[] dataLine = ConverStudentObjectToRecord(Student).Split(new string[] { Constants.Separator }, StringSplitOptions.None);
            return dataLine;

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

        public  void Add(clsStudent record)
        {
            if (IsValidStudent(record))
            {
                record.ID = CreateID();

                using (StreamWriter reDatabase = new StreamWriter(Constants.StudentsFile, true))
                {

                    reDatabase.WriteLine(ConverStudentObjectToRecord(record));

                }

            }
          
        }

        public void Update(clsStudent record)
        {

            if (IsValidStudent(record)) 
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
                MessageBox.Show("Edited Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fill in the voids", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

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

        public bool IsExit(string Username)
        {
            List<clsStudent> Students = GetAll();

            if (true)
            {
                foreach (clsStudent item in Students)
                {

                    if (item.ID == Username)
                    {

                        return true;

                    }
                }
            }

            return false;
        }

    }
}
