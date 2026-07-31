using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System.Repositories
{
    internal class UserService : IGenericService<clsUser>
    {
        private static clsUser ConvertRecordToUserObject(string record)
        {
            string[] DataRecord =
                record.Split(new string[] { Constants.Separator },
                StringSplitOptions.None);


            return new clsUser(
                DataRecord[0],
                DataRecord[1],
                DataRecord[2],
                DataRecord[3],
                Convert.ToBoolean(DataRecord[4])
            );
        }
        private static string ConverUserObjectToLine(clsUser User)
        {

            string UserRecord = "";
            UserRecord = User.FullName + Constants.Separator;
            UserRecord += User.Username + Constants.Separator;
            UserRecord += User.PasswordHash + Constants.Separator;
            UserRecord += User.Role + Constants.Separator;
            UserRecord += User.IsActive;
            return UserRecord;

        }
        private static void ChangeDate(List<clsUser> Users)
        {

            System.IO.File.WriteAllText(Constants.UsersFile, "");

            foreach (clsUser User in Users)
            {

                using (StreamWriter reDatabase = new StreamWriter(Constants.UsersFile, true))
                {

                    reDatabase.WriteLine(ConverUserObjectToLine(User));

                }
            }

        }

        public List<clsUser> GetAll()
        {
            List<clsUser> Users = new List<clsUser>();

            using (StreamReader reDatabase = new StreamReader(Constants.UsersFile))
            {
                string record;

                do
                {
                    record = reDatabase.ReadLine();

                    if (record != null)
                    {

                        Users.Add(ConvertRecordToUserObject(record));

                    }

                }
                while (record != null);

            }

            return Users;
        }

        public clsUser GetByUsername(string Username)
        {
            List<clsUser> Users = GetAll();

            foreach (clsUser item in Users)
            {

                if (item.Username == Username)
                {

                    return item;

                }
            }

            return new clsUser();

        }

        public void Add(clsUser record)
        {

            using (StreamWriter reDatabase = new StreamWriter(Constants.UsersFile, true))
            {

                reDatabase.WriteLine(ConverUserObjectToLine(record));

            }

        }

        public void Update(clsUser record)
        {

            List<clsUser> Users = GetAll();
        
            for (int item = 0; item < Users.Count; item++)
            {
                if (Users[item].Username == record.Username)
                {
                    Users[item] = record;
                    break;
                }
            }

            ChangeDate(Users);

        }

        public void Delete(clsUser record)
        {
            List<clsUser> Users = GetAll();

            foreach (clsUser User in Users)
            {
                
                if (User.Username == record.Username)
                {
                    Users.Remove(User);
                    break;
                }

            }

            ChangeDate(Users);
        }

    }
  
}