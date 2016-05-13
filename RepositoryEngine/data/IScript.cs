using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEngine.data
{
    public interface IScript
    {
        Guid Id { get; set; }
        string CreatedBy { get; set; }
        string CreatedOn { get; set; }
        int Executions { get; set; }
        string ScriptText { get; set; }
        EScriptType Type { get; set; }
    }
}
