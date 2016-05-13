using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaBot.interfaces;

namespace TriviaBot.objects
{
    public class TriviaQuestion : ITriviaQuestion
    {
        public string Question { get; }
        public string Answer { get; }
        public string Points { get; set; }
        public DateTime TimeAsked { get; set; }
        public bool Finished { get; set; }
        public List<string> Hints { get; }
        public string Hint => Hints[Hints.Count - 1];

        public TriviaQuestion(string question, string answer, string points, List<string> hints)
        {
            Question = question;
            Answer = answer;
            Points = points;
            Hints = hints;
            Finished = false;
        }
    }
}
