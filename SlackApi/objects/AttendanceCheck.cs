using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MargieBot.Models;

namespace SlackApi.objects
{
    public class AttendanceCheck
    {
        public DateTimeOffset ClassStartTime { get; set; }
        public string AttendanceApi { get; set; }
        public SlackChatHub Hub { get; set; }
        public bool Enabled { get; set; }
    }
}
