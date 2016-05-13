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
    public class BadWordsViewModel : ViewModelBase
    {
        public IEnumerable<IBadWords> BadWordItems => _repositoryService.GetAll();
        private readonly IBadWordRepository _repositoryService;

        public BadWordsViewModel(IBadWordRepository repositoryService)
        {
            _repositoryService = repositoryService;
        }
    }
}
