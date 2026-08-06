using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Repositories
{
    public interface IGenericRepository<T>
    {
        List<T> GetAll();

        T Find(string id);

        void Add(T entity);

        void Update(T entity);

        void Delete(string id);

        bool Exists(string id);
    }
}
