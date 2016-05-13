using System;

namespace RepositoryEngine.data
{
    public class Attendance : IAttendance
    {
        public string StudentName { get; set; }
        public string StudentId { get; set; }
        public DateTime Date { get; set; }
        public bool Present { get; set; }
        public Guid Id { get; set; }
    }
}