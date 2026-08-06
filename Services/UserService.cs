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

        public List<clsUser> GetAll()
        {

            return repository.GetAll();

        }

        public clsUser Find(string username)
        {

            return repository.Find(username);

        }

        public bool Add(clsUser student)
        {
            if (repository.Exists(student.Username))
                return false;

            repository.Add(student);
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

            if (!repository.Exists(username))
                return false;

            repository.Delete(username);
            return true;

        }


    }
  
}