using System;

namespace RepositoryEngine.data
{
    public class Trivia : ITrivia
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public int Points { get; set; }
        public string HintOne { get; set; }
        public string HintTwo { get; set; }
        public string HintThree { get; set; }
        public Guid Id { get; set; }
    }
}