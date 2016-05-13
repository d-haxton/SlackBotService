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
    public class ScriptViewModel : ViewModelBase
    {
        public IEnumerable<IScript> ScriptItems => _repositoryService.GetAll();
        private readonly IScriptRepository _repositoryService;

        public ScriptViewModel(IScriptRepository repositoryService)
        {
            _repositoryService = repositoryService;
        }
    }
}
