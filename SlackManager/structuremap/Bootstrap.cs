using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.ServiceLocation;
using RepositoryEngine.repository;
using StructureMap;
using StructureMap.Graph;

namespace SlackManager.structuremap
{
    public class Bootstrap
    {
        private static IContainer _theContainer;
        public static IContainer TheContainer => _theContainer ?? (_theContainer = CreateContainer());

        private static IServiceLocator _theServiceLocator;
        public static IServiceLocator TheServiceLocator => _theServiceLocator ?? (_theServiceLocator = CreateServiceLocator());

        private static IContainer CreateContainer()
        {
            return new Container(_ =>
            {
                _.Scan(x =>
                {
                    x.TheCallingAssembly();
                    x.AssemblyContainingType<IHistoryRepository>();
                    x.WithDefaultConventions();
                    x.SingleImplementationsOfInterface();
                });
            });
        }

        private static IServiceLocator CreateServiceLocator()
        {
            return new StructureMapServiceLocator(TheContainer);
        }
    }
}
