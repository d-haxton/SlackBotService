using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MargieBot.Models;
using MargieBot.Responders;
using SlackApi.interfaces;
using TriviaBot.interfaces;
using TriviaBot.objects;

namespace SlackApi.responders
{
    public interface ITriviaResponder : IResponder
    {
        
    }
    public class TriviaResponder : ITriviaResponder
    {
        private readonly ITriviaEngine _trivia;

        public TriviaResponder(ITriviaEngine trivia)
        {
            _trivia = trivia;
        }

        public bool CanRespond(ResponseContext context)
        {
            if (context.Message.ChatHub.Name.Contains("trivia"))
            {
                return _trivia.IsWinnerMessage(context.Message.Text);
            }
            return false;
        }

        public BotMessage GetResponse(ResponseContext context)
        {
            var inputMessage = new TriviaInputMessage(context.Message.Text, context.Message.User.FormattedUserID, DateTime.Now);
            var output = _trivia.GetWinnerMessage(inputMessage);
            return new BotMessage()
            {
                Text = $"Congratulations: {output.Input.User}! You have won {output.Question.Points} points."
            };
        }
    }
}
