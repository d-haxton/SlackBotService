using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizEngine.quizzes
{
    public interface IQuiz
    {
        string Question { get; set; }
        string Answer { get; set; }
        IQuizCode Code { get; set; }
    }
}
