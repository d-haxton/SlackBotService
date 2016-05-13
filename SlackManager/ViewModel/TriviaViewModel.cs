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
    public class TriviaViewModel : ViewModelBase
    {
        public IEnumerable<ITrivia> TriviaItems => _repositoryService.GetAll();
        private readonly ITriviaRepository _repositoryService;

        public TriviaViewModel(ITriviaRepository repositoryService)
        {
            _repositoryService = repositoryService;
        }
    }
}
