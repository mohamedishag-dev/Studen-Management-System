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

        T GetByUsername(string id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }

}
