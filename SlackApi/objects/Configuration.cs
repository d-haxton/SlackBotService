using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlackApi.interfaces;

namespace SlackApi.objects
{
    public class Configuration : IConfiguration
    {
        public IReadOnlyList<string> Aliases { get; }

        public Configuration()
        {
            Aliases = new List<string>()
            {
                "Random Bot"
            };
        }
    }
}
