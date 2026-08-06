using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Student_Management_System.Repositories
{
    internal class UserService : IGenericService<clsUser>
    {
        UserRepository repository = new UserRepository();

        private int CreateID()
        {
            List<clsUser> users = GetAll();
            return users.Count + 1;
        }

        public List<clsUser> GetAll()
        {

            return repository.GetAll();

        }

        public clsUser Find(string username)
        {

            return repository.Find(username);

        }

        public bool Add(clsUser user)
        {
            if (repository.Exists(user.Username))
                return false;

            user.ID = CreateID();

            repository.Add(user);
            return true;
        }

        public bool Update(clsUser record)
        {
            
            if (!repository.Exists(record.Username))
                return false;

            repository.Update(record);
            return true;

        }

        public bool Delete(string username)
        {

            if (username == "Admin")
                return false;
            
            if (!repository.Exists(username))
                return false;

            repository.Delete(username);
            return true;

        }

        public bool Exists(string username)
        {
            if (repository.Exists(username))
                return true;

            return false;
        }

    }

}