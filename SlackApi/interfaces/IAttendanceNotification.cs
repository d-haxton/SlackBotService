using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlackApi.objects;

namespace SlackApi.interfaces
{
    public interface IAttendanceNotification
    {
        IEnumerable<AttendanceCheck> Classes { get; }
        void Add(AttendanceCheck attendanceCheck);
        void Remove(AttendanceCheck attendanceCheck);
    }
}
