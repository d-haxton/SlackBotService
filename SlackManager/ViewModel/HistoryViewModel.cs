using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using RepositoryEngine.data;
using RepositoryEngine.repository;
using SlackManager.Services;

namespace SlackManager.ViewModel
{
    public class HistoryViewModel : ViewModelBase
    {
        public IEnumerable<IHistory> HistoryItems => _repositoryService.GetAll();

        private readonly IHistoryRepository _repositoryService;

        public HistoryViewModel(IHistoryRepository repositoryService)
        {
            _repositoryService = repositoryService;
        }
    }
}
