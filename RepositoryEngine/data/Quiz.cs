using System;

namespace RepositoryEngine.data
{
    public class Quiz : IQuiz
    {
        public string Class { get; set; }
        public DateTime Date { get; set; }
        public string Student { get; set; }
        public int Grade { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public Guid Id { get; set; }
    }
}