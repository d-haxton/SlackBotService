using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SlackApi.interfaces;

namespace SlackApi.objects
{
    public class AttendanceNotification : IAttendanceNotification
    {
        public AttendanceNotification()
        {
            //todo load from external save
            _classes = new List<AttendanceCheck>();
            CycleAttedenance();
        }

        private void CycleAttedenance()
        {
            foreach (var currentClass in _classes)
            {
                Task.Factory.StartNew(() => WaitUntilTime(currentClass));
            }
        }

        private async void WaitUntilTime(AttendanceCheck attendanceCheck)
        {
            while (attendanceCheck.Enabled)
            {
                if (
                    Math.Abs(attendanceCheck.ClassStartTime.TimeOfDay.TotalMinutes -
                             DateTimeOffset.Now.TimeOfDay.TotalMinutes) < 1)
                {
                    await Task.Delay(TimeSpan.FromMinutes(60));

                    //todo attendance stuff
                }
                else
                {
                    await Task.Delay(TimeSpan.FromMinutes(1));
                }
            }
        }

        private readonly List<AttendanceCheck> _classes;
        public IEnumerable<AttendanceCheck> Classes => _classes;
        public void Add(AttendanceCheck attendanceCheck)
        {
            attendanceCheck.Enabled = true;
            _classes.Add(attendanceCheck);
        }

        public void Remove(AttendanceCheck attendanceCheck)
        {
            var firstOrDefault = _classes.FirstOrDefault(c => c.Hub == attendanceCheck.Hub);
            if (firstOrDefault != null)
                firstOrDefault.Enabled = false;
        }
    }
}
