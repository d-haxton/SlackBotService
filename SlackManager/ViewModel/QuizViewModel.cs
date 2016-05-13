using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using RepositoryEngine.data;
using RepositoryEngine.repository;

namespace SlackManager.ViewModel
{
    public class QuizViewModel : ViewModelBase
    {
        public IEnumerable<IQuiz> QuizItems => _repositoryService.GetAll();
        private readonly IQuizRepository _repositoryService;

        public QuizViewModel(IQuizRepository repositoryService)
        {
            _repositoryService = repositoryService;
        }
    }
}
