using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using TriviaBot.interfaces;

namespace TriviaBot.objects
{
    public class TriviaEngine : ITriviaEngine
    {
        private readonly ITriviaIO _io;
        private readonly ITriviaQuestionEngine _questionEngine;
        private ITriviaQuestion Question { get; set; }
        public bool AskNewQuestions { get; set; } = true;
        public TriviaEngine(ITriviaIO io, ITriviaQuestionEngine questionEngine)
        {
            _io = io;
            _questionEngine = questionEngine;

            Task.Run(QuestionRunner);
        }

        private async Task QuestionRunner()
        {
            while (AskNewQuestions)
            {
                await AskQuestion(_questionEngine.NewQuestion);
                await Task.Delay(1000);
            }
        }

        private async Task AskQuestion(ITriviaQuestion question)
        {
            await Task.Delay(2500);
            Question = question;
            question.TimeAsked = DateTime.Now;
            while (question.Finished == false && DateTime.Now.Subtract(question.TimeAsked).Seconds < 120)
            {
                var timeLeft = (60 - DateTime.Now.Subtract(question.TimeAsked).Seconds);
                var points = int.Parse(question.Points) * timeLeft / 60;
                var message = new TriviaOutputMessage(question.Question, question.Hint, timeLeft.ToString(), points.ToString());
                _io.Say(message);
                await Task.Delay(15000);
            }
        }

        public bool IsWinnerMessage(string answer)
        {
            return string.Equals(answer, Question.Answer, StringComparison.CurrentCultureIgnoreCase);
        }

        public ITriviaWinnerMessage GetWinnerMessage(ITriviaInputMessage e)
        {
            var timeLeft = (60 - DateTime.Now.Subtract(Question.TimeAsked).Seconds);
            var points = int.Parse(Question.Points) * timeLeft / 60;

            Question.Points = points.ToString();

            var output = new TriviaWinnerMessage(Question, e);
            Question.Finished = true;
            return output;
        }
    }
}
