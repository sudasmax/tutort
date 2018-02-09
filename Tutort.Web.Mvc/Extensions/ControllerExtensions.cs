using System.Web.Mvc;
using Tutort.Core.Helpers;
using Unity;
using Unity.Registration;

namespace Tutort.Web.Mvc.Extensions
{
    public static class ControllerExtensions
    {
        public static IUnityContainer RegisterController<T>(this IUnityContainer container, params InjectionMember[] injectionMembers) where T : IController
        {
            Guard.ArgumentNotNull(container, "container");

            var controllerName = typeof(T).Name.Replace("Controller", string.Empty);
            container.RegisterType<IController, T>(controllerName, injectionMembers);

            return container;
        }
    }
}