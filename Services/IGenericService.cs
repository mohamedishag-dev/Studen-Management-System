using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Repositories
{
    public interface IGenericService<T> where T : class
    {
        List<T> GetAll();

        T Find(string id);

        bool Add(T entity);

        bool Update(T entity);

        bool Delete(string id);
    }

}
