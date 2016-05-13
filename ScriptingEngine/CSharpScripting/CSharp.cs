using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace ScriptingEngine.CSharpScripting
{
    public class CSharp
    {
        public object Compile(string script)
        {
            return CSharpScript.EvaluateAsync(script).Result;
        }
    }
}
