using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaBot.interfaces;

namespace TriviaBot.objects
{
    public class TriviaWinnerMessage : ITriviaWinnerMessage
    {
        public ITriviaQuestion Question { get; }
        public ITriviaInputMessage Input { get; }

        public TriviaWinnerMessage(ITriviaQuestion question, ITriviaInputMessage input)
        {
            Question = question;
            Input = input;
        }
    }
}
