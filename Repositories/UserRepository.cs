using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Student_Management_System.Repositories
{
    public class UserRepository : IGenericRepository<clsUser>
    {
        private static clsUser ConvertRecordToUserObject(string record)
        {
            string[] Record =
                record.Split(new string[] { Constants.Separator },
                StringSplitOptions.None);

            return new clsUser(Convert.ToInt32(Record[0]),
                Record[1],
                Record[2],
                Record[3],
                Convert.ToBoolean(Record[4]));

        }
        private static string ConverUserObjectToLine(clsUser user)
        {

            string record = "";
            record = user.ID + Constants.Separator;
            record += user.Username + Constants.Separator;
            record += user.PasswordHash + Constants.Separator;
            record += user.Role + Constants.Separator;
            record += user.IsActive;
            return record;

        }
        private static void SaveUsres(List<clsUser> Users)
        {

            System.IO.File.WriteAllText(Constants.UsersFile, "");

            using (StreamWriter reDatabase = new StreamWriter(Constants.UsersFile, true))
            {
                foreach (clsUser User in Users)
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

        public clsUser Find(string username)
        {
            List<clsUser> Users = GetAll();

            foreach (clsUser item in Users)
            {

                if (item.Username == username)
                {

                    return item;

                }
            }

            return null;
        }

        public void Add(clsUser user)
        {
            using (StreamWriter reDatabase = new StreamWriter(Constants.UsersFile, true))
            {

                reDatabase.WriteLine(ConverUserObjectToLine(user));

            }
        }

        public void Update(clsUser user)
        {

            List<clsUser> Users = GetAll();

            for (int item = 0; item < Users.Count; item++)
            {
                if (Users[item].Username == user.Username)
                {
                    Users[item] = user;
                    break;
                }
            }
            SaveUsres(Users);
        }

        public void Delete(string username)
        {
            List<clsUser> Users = GetAll();

            foreach (clsUser user in Users)
            {
                if (user.Username == username)
                {
                    Users.Remove(user);
                    break;
                }
            }

            SaveUsres(Users);
        }

        public bool Exists(string username)
        {
            List<clsUser> Users = GetAll();

            foreach (clsUser User in Users)
            {

                if (User.Username == username)
                {
                    return true;
                }

            }

            return false;
        }
    }
}
