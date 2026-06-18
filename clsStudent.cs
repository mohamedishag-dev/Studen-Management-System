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

        static string DatabasePath = Application.StartupPath + @"\Database.txt";
        private static string Seperator = "#//#";
        private static int TotalStudent = 0;

        private bool MarkDelete = false;
        public string ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public clsStudent()
        {
            ID = "";
            FirstName = "";
            LastName = "";
            Age = 0;
            Phone = "";
            Gender = "";
            Address = "";
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

        private static clsStudent _ConvertLineToStudentObject(string Line)
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

        public static int Total()
        {

            return TotalStudent;
        }

        public static void LoadStudentsDataFromFile(DataGridView dgvDatabase, bool IsAll = true)
        {
            TotalStudent = 0;
          
            StreamReader reDatabase = new StreamReader(DatabasePath);
            string reLine;

            do
            {
                reLine = reDatabase.ReadLine();

                if (reLine != null)
                {
                    string[] dataLine = reLine.Split(new string[] { Seperator }, StringSplitOptions.None);
                    dgvDatabase.Rows.Add(dataLine);
                    TotalStudent++;
                }
                if (TotalStudent == 5 && !IsAll)
                {
                    return;
                }
            }
            while (reLine != null);
            reDatabase.Close();

        }

        public static bool StudentCard(DataGridView dgvDatabase, clsStudent Student)
        {
            if (string.IsNullOrEmpty(Student.FirstName) || string.IsNullOrEmpty(Student.LastName) || Student.Age <= 0 || string.IsNullOrEmpty(Student.Phone)
              || string.IsNullOrEmpty(Student.Gender) || string.IsNullOrEmpty(Student.Address))
            {

                return false;

            }
            else
            {

                string reLine = _ConverStudentObjectToLine(Student);
                object[] dataLine = reLine.Split(new string[] { "#//#" }, StringSplitOptions.None);
                dgvDatabase.Rows.Add(dataLine);

                return true;
            }

        }

        public static string _ConverStudentObjectToLine(clsStudent Student)
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

        public static clsStudent Find(string ID)
        {

            clsStudent Student = new clsStudent();

            StreamReader reDatabase = new StreamReader(DatabasePath);
            string reLine;

            do
            {

                reLine = reDatabase.ReadLine();

                if (reLine != null)
                {

                    Student = _ConvertLineToStudentObject(reLine);
                    if (Student.ID == ID)
                    {
                        return Student;

                    }

                }
            }
            while (reLine != null);
            reDatabase.Close();

            Student = new clsStudent();

            return Student;
        }

        private static string GanretingID()
        {
            TotalStudent++;
            if (TotalStudent <= 9)
                return "STU00" + TotalStudent;
            else if (TotalStudent <= 99)
                return "STU0" + TotalStudent;
            else
                return "STU" + TotalStudent;

        }

        public static bool AddDataLineToFile(clsStudent Student)
        {

            if (string.IsNullOrEmpty(Student.FirstName) || string.IsNullOrEmpty(Student.LastName) || Student.Age <= 0 || string.IsNullOrEmpty(Student.Phone)
               || string.IsNullOrEmpty(Student.Gender) || string.IsNullOrEmpty(Student.Address))
            {

                return false;

            }

            else
            {
                Student.ID = GanretingID();
                StreamWriter SW = new StreamWriter(DatabasePath, true);
                SW.WriteLine(_ConverStudentObjectToLine(Student));
                SW.Close();
                
                return true;

            }

        }

        public static void _Update(clsStudent Student)
        {

            StreamReader reDatabase = new StreamReader(DatabasePath);
            string reLine;
            do
            {
                reLine = reDatabase.ReadLine();

                if (reLine != null)
                {
                    string[] dataLine = reLine.Split(new string[] { Seperator }, StringSplitOptions.None);

                    if (Student.ID == dataLine[0])
                    {
                        Student.MarkDelete = true;
                    }
                }

            }
            while (reLine != null);
            reDatabase.Close();


        }
      
        public static void DeleteStudent(string StudentID)
        {


            //StreamReader reDatabase = new StreamReader(DatabasePath);
            //System.IO.File.WriteAllText(DatabasePath, "");

            //string reLine;

            //do
            //{
            //    reLine = reDatabase.ReadLine();

            //    if (reLine != null)
            //    {
            //        string[] dataLine = reLine.Split(new string[] { Seperator }, StringSplitOptions.None);

            //        if (dataLine[0] == StudentID)
            //        {
            //            StreamWriter SW = new StreamWriter(DatabasePath, true);
            //            SW.WriteLine(reLine);
            //            SW.Close();
            //        }
            //    }
              
            //}
            //while (reLine != null);
            //reDatabase.Close();


            //List<string> Lines = System.IO.File.ReadAllLines(DatabasePath).ToList();

            //Lines.RemoveAll(Line =>
            //{
            //    string[] Data = Line.Split(new string[] { Seperator }, StringSplitOptions.None);

            //    return Data[0] == StudentID;

            //});

            //System.IO.File.WriteAllLines(DatabasePath, Lines);

            //if (MessageBox.Show("هل تريد حذف جميع البيانات؟",
            //                    "تأكيد",
            //                    MessageBoxButtons.YesNo,
            //                    MessageBoxIcon.Warning) == DialogResult.Yes)
            //{
            //    File.WriteAllText(DatabasePath, "");
            //    MessageBox.Show("تم حذف جميع البيانات بنجاح");
            //}
        }
        public static bool SaveDataLineToFile(clsStudent Student)
        {

            if (string.IsNullOrEmpty(Student.FirstName) || string.IsNullOrEmpty(Student.LastName) || Student.Age <= 0 || string.IsNullOrEmpty(Student.Phone)
               || string.IsNullOrEmpty(Student.Gender) || string.IsNullOrEmpty(Student.Address))
            {

                return false;

            }

            else
            {
                StreamWriter SW = new StreamWriter(DatabasePath, true);
                SW.WriteLine(_ConverStudentObjectToLine(Student));
                SW.Close();

                return true;

            }

        }

    }

}   