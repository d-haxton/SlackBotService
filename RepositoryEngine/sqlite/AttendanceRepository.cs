using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryEngine.data;
using RepositoryEngine.repository;

namespace RepositoryEngine.sqlite
{
    public class AttendanceRepository : BaseRepository<Attendance>, IAttendanceRepository
    {
        public AttendanceRepository()
        {
            Db = new SlackContext();
            Db.Database.EnsureCreated();
            Database = Db.Attendances;
        }
    }
}
