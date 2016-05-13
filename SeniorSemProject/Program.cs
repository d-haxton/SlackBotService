using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScriptingEngine.CSharpScripting;
using ScriptingEngine.IronPython;
using SeniorSemProject.structuremap;
using SlackApi;
using SlackApi.interfaces;
using SlackApi.objects;

namespace SeniorSemProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //var configuration = new Configuration();
            //var wordlist = new WordList();
            //var slackInterface = new SlackInterface(configuration, wordlist, new Chat());
            //var driver = new Driver(slackInterface);
            //driver.Connect();

            IoCContainer.TheContainer.GetInstance<ISlackInterface>();
            //var ip = new IronPython();
            //ip.Compile();

            //var cs = new CSharp();
            //var script = @"int Add(int x, int y) {
            // return x+y;
            // }
            // Add(1, 4)";
            //var output = cs.Compile(script);
            //Console.WriteLine(output);
            while (true)
            {
                if (Console.ReadLine() == "quit")
                    break;
            }
        }
    }
}
