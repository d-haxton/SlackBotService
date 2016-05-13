using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity.Storage;
using RepositoryEngine.data;
using RepositoryEngine.repository;

namespace RepositoryEngine.sqlite
{
    public class TriviaRepository : BaseRepository<Trivia>, ITriviaRepository
    {
        public TriviaRepository()
        {
            Db = new SlackContext();
            Db.Database.EnsureCreated();
            Database = Db.Trivias;
        }
    }
}
