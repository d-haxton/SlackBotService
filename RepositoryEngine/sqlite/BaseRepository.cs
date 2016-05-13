using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using RepositoryEngine.data;

namespace RepositoryEngine.sqlite
{
    public class BaseRepository<T> where T : class
    {
        protected SlackContext Db;
        protected DbSet<T> Database; 

        public void Insert(T entity)
        {
            Database.Add(entity);
            Db.SaveChanges();
        }

        public void Delete(T entity)
        {
            Database.Remove(entity);
            Db.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            Database.AttachRange(Database.Select(x => x));
            return Database.Select(x => x).ToList();
        }
    }
}
