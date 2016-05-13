using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MargieBot;
using MargieBot.Models;
using SlackApi.interfaces;
using SlackApi.responders;
using TriviaBot.interfaces;

namespace SlackApi.objects
{
    public class SlackInterface : ISlackInterface
    {
        private readonly ISlackBot _bot;
        private readonly ITriviaIO _triviaIo;
        public Bot SlackBot => _bot.Bot;

        public SlackInterface(ISlackBot bot, ITriviaIO triviaIo, ITriviaController triviaController)
        {
            _bot = bot;
            _triviaIo = triviaIo;
            triviaController.UpdateTrivia += OnUpdateTrivia;
        }

        private void OnUpdateTrivia(object sender, bool e)
        {
            if (e)
            {
                _triviaIo.OutputMessage += OutputTriviaMessage;
            }
            else
            {
                _triviaIo.OutputMessage -= OutputTriviaMessage;
            }
        }

        private async void OutputTriviaMessage(object sender, ITriviaOutputMessage e)
        {
            var chathub = _bot.Bot.ConnectedChannels.First(x => x.Name.ToLower().Contains("trivia"));
            var message = new BotMessage()
            {
                ChatHub = chathub,
                Text = $"The question has been posed: {e.Question}\nWith the following hint: {e.Hint}\nThere is only {e.TimeLeft} seconds left, and the question is currently worth {e.Points}"
            };
            await _bot.Bot.Say(message);
        }
    }
}
