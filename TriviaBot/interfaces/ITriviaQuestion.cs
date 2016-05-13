using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaBot.interfaces
{
    public interface ITriviaQuestion
    {
        string Question { get; }
        string Answer { get; }
        string Points { get; set; }
        DateTime TimeAsked { get; set; }
        bool Finished { get; set; }
        List<string> Hints { get; } 
        string Hint { get; }
    }
}
