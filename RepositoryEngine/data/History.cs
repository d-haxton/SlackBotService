using System;

namespace RepositoryEngine.data
{
    public class History : IHistory
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
        public string FormattedUserID { get; set; }
        public string UserID { get; set; }
        public string ChatHubID { get; set; }
        public string ChatName { get; set; }
        public string RawData { get; set; }
    }
}