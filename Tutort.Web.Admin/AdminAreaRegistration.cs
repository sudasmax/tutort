using System.Web.Mvc;
using Tutort.Core.Helpers;
using Unity;

namespace Tutort.Web.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "AdminExternal";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            Guard.ArgumentNotNull(context, "context");

            // register area's container in parent container using AreaName as a key
            IUnityContainer parentContainer = (IUnityContainer)context.State;
            IUnityContainer container = parentContainer.CreateChildContainer();
            parentContainer.RegisterInstance(AreaName, container);

            RouteConfig.RegisterRoutes(context.Routes);
            DependencyConfig.RegisterDependencies(container);
        }
    }
}