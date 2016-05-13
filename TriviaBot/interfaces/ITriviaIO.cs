using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaBot.interfaces
{
    public interface ITriviaIO
    {
        void Say(ITriviaOutputMessage message);
        event EventHandler<ITriviaOutputMessage> OutputMessage;
    }
}
