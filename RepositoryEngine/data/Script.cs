using System;

namespace RepositoryEngine.data
{
    public enum EScriptType
    {
        CSharp,
        Python
    }
    public class Script : IScript
    {
        public Guid Id { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public int Executions { get; set; }
        public string ScriptText { get; set; }
        public EScriptType Type { get; set; }
    }
}