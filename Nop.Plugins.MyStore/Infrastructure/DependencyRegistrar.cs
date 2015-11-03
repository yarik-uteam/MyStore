using System.Web.Mvc;
using Autofac;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;
using Nop.Plugins.MyStore.Filters;

namespace Nop.Plugins.MyStore.Infrastructure
{
    public class DependencyRegistrar: IDependencyRegistrar
    {
        public void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            FilterProviders.Providers.Add(new NopFilterProvider());
        }

        public int Order => 0;
    }
}