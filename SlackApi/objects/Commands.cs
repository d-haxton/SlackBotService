using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlackApi.interfaces;

namespace SlackApi.objects
{
    public class Commands : ICommands
    {
        public IEnumerable<string> EnumerableCommands { get; }

        public Commands()
        {
            EnumerableCommands = new List<string>()
            {
                "!quiz",
                "!compile",
                "!help",
                "!attendance",
                "!badword",
                "!trivia"
            };
        }
    }
}
