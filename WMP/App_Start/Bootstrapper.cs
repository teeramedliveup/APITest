using Autofac;
using Autofac.Core.Lifetime;
using Autofac.Integration.Mvc;
using AutoMapper;
using System.Reflection;
using System.Web.Mvc;
using Hangfire;

namespace WMP
{
    public static class Bootstrapper
    {
        public static void Run()
        {
            SetAutofacContainer();
        }

        private static void SetAutofacContainer()
        {
            //var requestTag = MatchingScopeLifetimeTags.RequestLifetimeScopeTag;
            //var jobTag = AutofacJobActivator.LifetimeScopeTag;

            //var builder = new ContainerBuilder();
            //builder.RegisterControllers(Assembly.GetExecutingAssembly());
            //builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest(jobTag);
            //builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest(jobTag);

            //builder.RegisterInstance(AutoMapperServiceConfiguration.Mapper)
            //    .As<IMapper>()
            //    .SingleInstance();

            //builder.RegisterAssemblyTypes(typeof(DbHelper).Assembly)
            //    .Where(t => t.Name.EndsWith("Helper"))
            //    .AsImplementedInterfaces()
            //   .InstancePerRequest(jobTag);

            //builder.RegisterAssemblyTypes(typeof(LoggingInfra).Assembly)
            //    .Where(t => t.Name.EndsWith("Infra"))
            //    .AsImplementedInterfaces()
            //   .InstancePerRequest(jobTag);

            //builder.RegisterAssemblyTypes(typeof(GS_PROJECTRepository).Assembly)
            //    .Where(t => t.Name.EndsWith("Repository"))
            //    .AsImplementedInterfaces()
            //   .InstancePerRequest(jobTag);

            //builder.RegisterAssemblyTypes(typeof(MasterDomain).Assembly)
            //   .Where(t => t.Name.EndsWith("Domain"))
            //   .AsImplementedInterfaces()
            //   .InstancePerRequest(jobTag);

            //builder.RegisterAssemblyTypes(typeof(UserApplication).Assembly)
            //   .Where(t => t.Name.EndsWith("Application"))
            //   .AsImplementedInterfaces()
            //   .InstancePerRequest(jobTag);

            //IContainer container = builder.Build();
            //GlobalConfiguration.Configuration.UseAutofacActivator(container);
            //JobActivator.Current = new AutofacJobActivator(container);

            //// Set dependency resolver for MVC
            //DependencyResolver.SetResolver(new Autofac.Integration.Mvc.AutofacDependencyResolver(container));
        }
    }
}