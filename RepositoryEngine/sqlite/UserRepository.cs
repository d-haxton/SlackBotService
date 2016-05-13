using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using RepositoryEngine.data;
using RepositoryEngine.repository;

namespace RepositoryEngine.sqlite
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository()
        {
            Db = new SlackContext();
            Db.Database.EnsureCreated();
            Database = Db.Users;
        }
    }
    //public class UserRepository : IUserRepository
    //{
    //    public UserRepository()
    //    {
    //        using (var db = new SlackContext())
    //        {
    //            db.Database.Migrate();
    //        }
    //    }

    //    public void Insert(User entity)
    //    {
    //        using (var db = new SlackContext())
    //        {
    //            db.Users.Add(entity);
    //        }
    //    }

    //    public void Delete(User entity)
    //    {
    //        using (var db = new SlackContext())
    //        {
    //            db.Users.Remove(entity);
    //        }
    //    }

    //    public IEnumerable<User> GetAll()
    //    {
    //        using (var db = new SlackContext())
    //        {
    //            return db.Users.Select(x => x);
    //        }
    //    }

    //    public User GetById(Guid id)
    //    {
    //        using (var db = new SlackContext())
    //        {
    //            return db.Users.FirstOrDefault(x => x.Id == id);
    //        }
    //    }
    //}
}
