using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryEngine.data;
using RepositoryEngine.repository;

namespace RepositoryEngine.sqlite
{
    public class BadWordRepository :BaseRepository<BadWords>, IBadWordRepository
    {
        public BadWordRepository()
        {
            Db = new SlackContext();
            Db.Database.EnsureCreated();
            Database = Db.BadWordses;
        }
    }
}
