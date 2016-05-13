using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaBot.interfaces;

namespace TriviaBot.objects
{
    public class TriviaIO : ITriviaIO
    {
        public void Say(ITriviaOutputMessage message)
        {
            OutputMessage?.Invoke(null, message);
        }

        public event EventHandler<ITriviaOutputMessage> OutputMessage = delegate { };
    }
}
