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
            string[] DataRecord =
                record.Split(new string[] { Constants.Separator },
                StringSplitOptions.None);

            clsUser user = new clsUser();
            user.FullName = DataRecord[0];
            user.Username = DataRecord[1];
            user.PasswordHash = DataRecord[2];
            user.Role = DataRecord[3];
            user.IsActive = Convert.ToBoolean(DataRecord[4]);

            return user;

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

            return new clsUser();
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
