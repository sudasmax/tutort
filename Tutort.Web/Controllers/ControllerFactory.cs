using System.Web.Mvc;
using System.Web.Routing;
using Tutort.Core.Helpers;
using Unity;

namespace Tutort.Web.Controllers
{
    public class ControllerFactory : DefaultControllerFactory
    {
        private readonly IUnityContainer container;

        public ControllerFactory(IUnityContainer container)
        {
            Guard.ArgumentNotNull(container, "container");

            this.container = container;
        }

        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            if (requestContext.RouteData.Values.ContainsKey("area"))
            {
                return this.CreateAreaController((string)requestContext.RouteData.Values["area"], controllerName);
            }

            if (container.IsRegistered<IController>(controllerName))
            {
                return container.Resolve<IController>(controllerName);
            }

            return base.CreateController(requestContext, controllerName);
        }

        private IController CreateAreaController(string areaName, string controllerName)
        {
            var areaContainer = container.Resolve<IUnityContainer>(areaName);
            return areaContainer.Resolve<IController>(controllerName);
        }
    }
}