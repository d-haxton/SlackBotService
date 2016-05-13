using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryEngine.repository;
using SeniorSemProject.structuremap.registry;
using SlackApi.interfaces;
using StructureMap;
using StructureMap.Graph;
using TriviaBot.interfaces;

namespace SeniorSemProject.structuremap
{
    public static class IoCContainer
    {
        public static Container TheContainer = _theContainer ?? (_theContainer = CreateContainer());

        private static Container CreateContainer()
        {
            return new Container(_ =>
            {
                _.Scan(x =>
                {
                    x.AssemblyContainingType<ISlackBot>();
                    x.AssemblyContainingType<ITriviaEngine>();
                    x.AssemblyContainingType<IHistoryRepository>();
                    x.TheCallingAssembly();
                    x.WithDefaultConventions();
                    x.SingleImplementationsOfInterface();
                });
                _.IncludeRegistry<SlackRegistry>();
                _.IncludeRegistry<TriviaBotRegistry>();
            });
        }

        private static Container _theContainer;
    }
}
