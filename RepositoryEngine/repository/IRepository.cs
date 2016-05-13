using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEngine.repository
{
    public interface IRepository<T> where T: class 
    {
        //crud
        void Insert(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
    }
}
