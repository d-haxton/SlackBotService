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
    public class HistoryRepository : BaseRepository<History>, IHistoryRepository
    {
        public HistoryRepository()
        {
            Db = new SlackContext();
            Db.Database.EnsureCreated();
            Database = Db.Histories;
        }
    }
    //public class HistoryRepository : IHistoryRepository
    //{
    //    private SlackContext db;

    //    public HistoryRepository()
    //    {
    //        db = new SlackContext();
    //        db.Database.EnsureCreated();
    //    }

    //    public void Insert(History entity)
    //    {
    //        db.Histories.Add(entity);
    //        db.SaveChanges();
    //    }

    //    public void Delete(History entity)
    //    {
    //        db.Histories.Remove(entity);
    //        db.SaveChanges();
    //    }

    //    public IEnumerable<History> GetAll()
    //    {
    //        List<History> history;
    //        db.Histories.AttachRange(db.Histories.Select(x => x));
    //        history = db.Histories.Select(x => x).ToList();
    //        return history;
    //    }

    //    public History GetById(Guid id)
    //    {
    //        return db.Histories.FirstOrDefault(x => x.Id == id);
    //    }
    //}
}