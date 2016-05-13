using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaBot.interfaces
{
    public interface ITriviaOutputMessage
    {
        string Question { get; }
        string Hint { get; }
        string TimeLeft { get; }
        string Points { get; }
    }

    public interface ITriviaInputMessage
    {
        string Answer { get; }
        string User { get; }
        DateTime AnsweredAt { get; }
    }
}
