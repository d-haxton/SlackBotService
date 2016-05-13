using System.IO;
using IronPython.Hosting;

namespace ScriptingEngine.IronPython
{
    public class IronPython
    {
        public void Compile(string text)
        {
            File.WriteAllText("Python.py", text);
            var ipy = Python.CreateRuntime();
            dynamic test = ipy.UseFile("Python.py");
            test.Simple();
        }
    }
}
