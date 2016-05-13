using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MargieBot.Models;
using MargieBot.Responders;
using RepositoryEngine.data;
using RepositoryEngine.repository;

namespace SlackApi.responders
{
    public interface IHistoryResponder : IResponder
    {
    }

    public class HistoryResponder : IHistoryResponder
    {
        private readonly IHistoryRepository _historyRepository;

        public HistoryResponder(IHistoryRepository historyRepository)
        {
            _historyRepository = historyRepository;
        }

        public bool CanRespond(ResponseContext context)
        {
            var history = new History
            {
                Id = Guid.NewGuid(),
                Message = context.Message.Text,
                FormattedUserID = context.Message.User.FormattedUserID,
                UserID = context.Message.User.ID,
                ChatHubID = context.Message.ChatHub.ID,
                ChatName = context.Message.ChatHub.Name,
                RawData = context.Message.RawData
            };
            _historyRepository.Insert(history);
            return false;
        }

        public BotMessage GetResponse(ResponseContext context)
        {
            throw new Exception("Unreachable block of code has been reached. Someone goofed.");
        }
    }
}
