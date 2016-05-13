using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizEngine.quizzes
{
    public class Quiz : IQuiz
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public IQuizCode Code { get; set; }

        public Quiz()
        {
            
        }

        public Quiz(string question, string answer, IQuizCode code)
        {
            Question = question;
            Answer = answer;
            Code = code;
        }
    }
}
