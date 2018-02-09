using Tutort.Core.Helpers;
using Tutort.Web.Admin.Controllers;
using Tutort.Web.Mvc.Extensions;
using Unity;

namespace Tutort.Web.Admin
{
    public class DependencyConfig
    {
        public static void RegisterDependencies(IUnityContainer container)
        {
            Guard.ArgumentNotNull(container, "container");

            #region Controllers

            container
                .RegisterController<HomeController>();

            #endregion
        }
    }
}