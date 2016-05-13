using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaBot.interfaces;

namespace TriviaBot.objects
{
    public class TriviaOutputMessage : ITriviaOutputMessage
    {
        public string Question { get; }
        public string Hint { get; }
        public string TimeLeft { get; }
        public string Points { get; }

        public TriviaOutputMessage(string question, string hint, string timeLeft, string points)
        {
            Question = question;
            Hint = hint;
            TimeLeft = timeLeft;
            Points = points;
        }
    }
}
