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
    public class ScriptRepository : BaseRepository<Script>, IScriptRepository
    {
        public ScriptRepository()
        {
            Db = new SlackContext();
            Db.Database.EnsureCreated();

            Database = Db.Scripts;
        }
    }
    //public class ScriptRepository : IScriptRepository
    //{
    //    public ScriptRepository()
    //    {
    //        using (var db = new SlackContext())
    //        {
    //            db.Database.Migrate();
    //        }
    //    }

    //    public void Insert(Script entity)
    //    {
    //        using (var db = new SlackContext())
    //        {
    //            db.Scripts.Add(entity);
    //            db.SaveChanges();
    //        }
    //    }

    //    public void Delete(Script entity)
    //    {
    //        using (var db = new SlackContext())
    //        {
    //            db.Scripts.Remove(entity);
    //            db.SaveChanges();
    //        }
    //    }

    //    public IEnumerable<Script> GetAll()
    //    {
    //        using (var db = new SlackContext())
    //        {
    //            return db.Scripts.Select(x => x);
    //        }
    //    }

    //    public Script GetById(Guid id)
    //    {
    //        using (var db = new SlackContext())
    //        {
    //            return db.Scripts.FirstOrDefault(x => x.Id == id);
    //        }
    //    }
    //}
}
