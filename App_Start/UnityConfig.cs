using Skote.Services.Person.Dtos;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Skote
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            container.RegisterType<IPersonAppServices, PersonAppServices>();
        }
    }
}