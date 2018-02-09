using System;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;

namespace Tutort.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            IUnityContainer container = new UnityContainer();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DependencyConfig.RegisterDependencies(container);
            MapperConfig.RegisterAllMapping();

            AreaRegistration.RegisterAllAreas(container);

            ControllerBuilder.Current.SetControllerFactory(container.Resolve<IControllerFactory>());
        }
    }
}
