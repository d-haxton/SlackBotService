using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MargieBot;

namespace SlackApi.interfaces
{
    public interface ISlackBot
    {
        Bot Bot { get;  }
    }
}
