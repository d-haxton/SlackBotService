using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEngine.data
{
    public interface IQuiz
    {
        string Class { get; set; }
        DateTime Date { get; set; }
        string Student { get; set; }
        int Grade { get; set; }
        string Question { get; set; }
        string Answer { get; set; }
    }
}
