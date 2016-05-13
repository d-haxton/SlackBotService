using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaBot.interfaces;

namespace TriviaBot.objects
{
    public class TriviaQuestionEngine : ITriviaQuestionEngine
    {
        public ITriviaQuestion NewQuestion => _questionList.PickRandom(1).FirstOrDefault();

        private readonly List<ITriviaQuestion> _questionList = new List<ITriviaQuestion>(); 
        public TriviaQuestionEngine()
        {
            _questionList.Add(new TriviaQuestion("What in Cornwall is the most southerly point of mainland Britain?", "Lizard Point", "100", new List<string>() { "<no hint>" }));
            _questionList.Add(new TriviaQuestion("Alan Minter was undisputed World boxing champion at which weight?", "Middleweight", "100", new List<string>() { "<no hint>" }));
            _questionList.Add(new TriviaQuestion("What is the other name for Wildebeest?", "GNU", "100", new List<string>() { "<no hint>" }));
            _questionList.Add(new TriviaQuestion("What is Canada's national animal?", "Beaver", "100", new List<string>() { "<no hint>" }));
        }

    }
    public static class EnumerableExtension
    {
        public static T PickRandom<T>(this IEnumerable<T> source)
        {
            return source.PickRandom(1).Single();
        }

        public static IEnumerable<T> PickRandom<T>(this IEnumerable<T> source, int count)
        {
            return source.Shuffle().Take(count);
        }

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            return source.OrderBy(x => Guid.NewGuid());
        }
    }
}
