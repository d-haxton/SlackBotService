namespace TriviaBot.interfaces
{
    public interface ITriviaEngine
    {
        bool AskNewQuestions { get; set; }
        bool IsWinnerMessage(string answer);
        ITriviaWinnerMessage GetWinnerMessage(ITriviaInputMessage e);
    }
}