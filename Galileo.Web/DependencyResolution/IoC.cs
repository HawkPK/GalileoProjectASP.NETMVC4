using Galileo.Domain;
using Galileo.Web.Infrastructure;
using StructureMap;
using StructureMap.Graph;

namespace Galileo.Web {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            x.For<IDepartmentSource>().Use<DepartmentDB>();
                        });
            return ObjectFactory.Container;
        }
    }
}