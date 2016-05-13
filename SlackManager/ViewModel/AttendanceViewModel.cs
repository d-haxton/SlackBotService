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
    public class AttendanceViewModel : ViewModelBase
    {
        public IEnumerable<IAttendance> AttendanceItems => _repositoryService.GetAll();
        private readonly IAttendanceRepository _repositoryService;

        public AttendanceViewModel(IAttendanceRepository repositoryService)
        {
            _repositoryService = repositoryService;
        }
    }
}
