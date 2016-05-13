using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryEngine.data;
using RepositoryEngine.repository;
using ScriptingEngine.CSharpScripting;

namespace ScriptingEngine.Scripting
{

    public interface ISlackScripting
    {
        void AddScript(string script, EScriptType type);
        void Execute(Guid id);
    }

    public class SlackScripting : ISlackScripting
    {
        private readonly IScriptRepository _scriptRepository;

        public SlackScripting(IScriptRepository scriptRepository)
        {
            _scriptRepository = scriptRepository;
        }

        public void AddScript(string scriptText, EScriptType type)
        {
            var script = new Script()
            {
                CreatedBy = "null",
                CreatedOn = DateTime.Now.ToString(CultureInfo.CurrentCulture),
                Executions = 0,
                Id = Guid.NewGuid(),
                ScriptText = scriptText,
                Type = type
            };
            _scriptRepository.Insert(script);
        }

        public void Execute(Guid id)
        {
            var script = _scriptRepository.GetAll().FirstOrDefault(x => x.Id == id);
            if (script?.Type == EScriptType.CSharp)
            {
                var cs = new CSharp();
                cs.Compile(script.ScriptText);
                script.Executions++;
            }
            else if(script?.Type == EScriptType.Python)
            {
                var python = new IronPython.IronPython();
                python.Compile(script.ScriptText);
                script.Executions++;
            }
        }
    }
}
