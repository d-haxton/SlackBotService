using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaBot.interfaces;

namespace TriviaBot.objects
{
    public class TriviaInputMessage : ITriviaInputMessage
    {
        public string Answer { get; }
        public string User { get; }
        public DateTime AnsweredAt { get; }

        public TriviaInputMessage(string answer)
        {
            Answer = answer;
        }
        public TriviaInputMessage(string answer, string user, DateTime answeredAt)
        {
            Answer = answer;
            User = user;
            AnsweredAt = answeredAt;
        }
    }
}
