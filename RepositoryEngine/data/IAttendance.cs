using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEngine.data
{
    public interface IAttendance
    {
        string StudentName { get; set; }
        string StudentId { get; set; }
        DateTime Date { get; set; }
        bool Present { get; set; }
    }
}
