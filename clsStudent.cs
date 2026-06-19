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

        private static string DatabasePath = Application.StartupPath + @"\Database.txt";
        private static string Seperator = "#//#";

        public string ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public clsStudent()
        {
            ID = null;
            FirstName = null;
            LastName = null;
            Age = 0;
            Phone = null;
            Gender = null;
            Address = null;
        }

        public clsStudent(string iD, string firstName, string lastName, int age, string phone, string gender, string address)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            Phone = phone;
            Address = address;
        }

        private static clsStudent ConvertLineToStudentObject(string Line)
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

        private static string ConverStudentObjectToLine(clsStudent Student)
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

        public static List<clsStudent> LoadStudents()
        {

            List<clsStudent> students = new List<clsStudent>();

            using (StreamReader reDatabase = new StreamReader(DatabasePath))
            {
                string reLine;

                do
                {
                    reLine = reDatabase.ReadLine();

                    if (reLine != null)
                    {

                        students.Add(ConvertLineToStudentObject(reLine));

                    }

                }
                while (reLine != null);

            }

            return students;
        }

        public static clsStudent Find(string StudentID)
        {

            List<clsStudent> Students = LoadStudents();

            foreach (var item in Students)
            {

                if (item.ID == StudentID)
                {

                    return item;

                }
            }
            clsStudent studentEmtpy = new clsStudent();
            return studentEmtpy;

        }

        public static bool IsValidStudent(clsStudent Student)
        {
            return !string.IsNullOrWhiteSpace(Student.FirstName)
                && !string.IsNullOrWhiteSpace(Student.LastName)
                && Student.Age > 0
                && !string.IsNullOrWhiteSpace(Student.Phone)
                && !string.IsNullOrWhiteSpace(Student.Gender)
                && !string.IsNullOrWhiteSpace(Student.Address);
        }

        private static string GenerateID()
        {

            List<clsStudent> Students = LoadStudents();
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
       
        public static bool Add(clsStudent Student)
        {

            if (IsValidStudent(Student))
            {
                Student.ID = GenerateID();

                using (StreamWriter reDatabase = new StreamWriter(DatabasePath, true))
                {

                    reDatabase.WriteLine(ConverStudentObjectToLine(Student));
                    return true;
                }

            }
            else
            {

                return false;

            }

        }

        private static void SaveStudents(List<clsStudent> Students)
        {

            System.IO.File.WriteAllText(DatabasePath, "");

            foreach (clsStudent Student in Students)
            {

                using (StreamWriter reDatabase = new StreamWriter(DatabasePath, true))
                {

                    reDatabase.WriteLine(ConverStudentObjectToLine(Student));

                }
            }


        }

        public static bool UpdateStudent(clsStudent StudentEdit)
        {
            if (IsValidStudent(StudentEdit))
            {

                List<clsStudent> Students = LoadStudents();

                for (int item = 0; item < Students.Count; item++)
                {
                    if (Students[item].ID == StudentEdit.ID)
                    {
                        Students[item] = StudentEdit;
                        break;
                    }
                }

                SaveStudents(Students);
                return true;
            }
            return false;
        }

        public static bool DeleteStudent(clsStudent StudentDelete)
        {
            if (IsValidStudent(StudentDelete))
            {

                List<clsStudent> Students = LoadStudents();

                for (int item = 0; item < Students.Count; item++)
                {
                    if (Students[item].ID == StudentDelete.ID)
                    {
                        Students.RemoveAt(item); 
                        break;
                    }
                }

                SaveStudents(Students);
                return true;
            }
            return false;
        }

        public static void DeleteStudent(string StudentID)
        {

            clsStudent Student = Find(StudentID);
            DeleteStudent(Student);

        }

        public static string[] StudentSearch(clsStudent Student)
        {

            string[] dataLine = ConverStudentObjectToLine(Student).Split(new string[] { Seperator }, StringSplitOptions.None);
            return dataLine;

        }

    }

}   