using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MargieBot;
using RepositoryEngine.repository;
using SlackApi.interfaces;
using SlackApi.responders;
using TriviaBot.interfaces;

namespace SlackApi.objects
{
    public class SlackBot : ISlackBot
    {
        public Bot Bot { get; }

        // ReSharper disable once SuggestBaseTypeForParameter
        public SlackBot(IConfiguration configuration, IBadWordRepository list, IHistoryResponder historyResponder, ICommandResponder commandResponder, ITriviaResponder triviaResponder, IScriptingResponder scriptingResponder)
        {
            Bot = new Bot
            {
                Aliases = configuration.Aliases
            };

            Bot.Responders.Add(new AutoModeratorResponder(list, this));
            Bot.Responders.Add(triviaResponder);
            Bot.Responders.Add(historyResponder);
            Bot.Responders.Add(commandResponder);
            Bot.Responders.Add(scriptingResponder);
            Connect();
        }

        private async void Connect()
        {
            await Bot.Connect("xoxb-23425258787-dvCEaiSiqKkjuzhOrMBSGZRi");
        }
    }
}
