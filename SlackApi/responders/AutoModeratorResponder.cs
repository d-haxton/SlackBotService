using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MargieBot.Models;
using MargieBot.Responders;
using RepositoryEngine.repository;
using SlackApi.interfaces;

namespace SlackApi.responders
{
    public interface IAutoModeratorResponder : IResponder
    {
        
    }
    public class AutoModeratorResponder : IAutoModeratorResponder
    {
        private readonly IBadWordRepository _badWordRepository;
        private readonly ISlackBot _bot;

        public AutoModeratorResponder(IBadWordRepository badWordRepository, ISlackBot bot)
        {
            _badWordRepository = badWordRepository;
            _bot = bot;
        }

        public bool CanRespond(ResponseContext context)
        {
            var messageSplit = context.Message.Text.Split(' ');
            return messageSplit.Any(message => _badWordRepository.GetAll().Select(x => x.Word).ToList().Contains(message));
        }

        public BotMessage GetResponse(ResponseContext context)
        {
            var name = context.UserNameCache[context.Message.User.ID];
            var hub = _bot.Bot.ConnectedDMs.FirstOrDefault(c => c.Name.TrimStart('@') == name);
            return new BotMessage
            {
                ChatHub = hub,
                Text =
                    $"{context.Message.User.FormattedUserID}, please refrain from using such language in public chat rooms."
            };
        }
    }
}
