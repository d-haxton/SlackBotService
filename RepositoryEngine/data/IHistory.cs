using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEngine.data
{
    public interface IHistory
    {
        Guid Id { get; set; }
        string Message { get; set; }
        string FormattedUserID { get; set; }
        string UserID { get; set; }
        string ChatHubID { get; set; }
        string ChatName { get; set; }
        string RawData { get; set; }
    }
}
