using System.Data.Entity;
using System.Reflection;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using OKMS.WeiChat.Model;

namespace OKMS.WeiChat
{
    public class AutofacConfig
    {
        public static void RegisterAutofac()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterAssemblyTypes(Assembly.Load("OKMS.WeiChat.Repository")).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(Assembly.Load("OKMS.WeiChat.Service")).AsImplementedInterfaces();
            builder.Register(options => new WeiChatDataContext("name=connectionString"))
                .As<DbContext>()
                .InstancePerLifetimeScope()
                .InstancePerRequest();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}