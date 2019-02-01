using Cencosud.Repositories;
using Cencosud.Services;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace Cencosud
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            // container.RegisterType<ITestService, TestService>();
            container.RegisterType<IClientRepository, ClientRepository>();
            container.RegisterType<IClientService, ClientService>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}