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
    public class UserViewModel : ViewModelBase
    {
        public IEnumerable<IUser> UserItems => _repositoryService.GetAll();

        private readonly IUserRepository _repositoryService;

        public UserViewModel(IUserRepository repositoryService)
        {
            _repositoryService = repositoryService;
        }
    }
}
