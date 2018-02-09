using System.Web.Mvc;
using Tutort.Core.Caching.Interfaces;
using Tutort.Core.Caching.Services;
using Tutort.Core.Helpers;
using Tutort.SocialNetworks.Instagram.Interfaces;
using Tutort.SocialNetworks.Instagram.Services;
using Tutort.SocialNetworks.Social.Interfaces;
using Tutort.SocialNetworks.Social.Services;
using Tutort.Web.Controllers;
using Tutort.Web.Mvc.Extensions;
using Unity;
using Unity.Injection;

namespace Tutort.Web
{
    public class DependencyConfig
    {
        public static void RegisterDependencies(IUnityContainer container)
        {
            Guard.ArgumentNotNull(container, "container");

            // Services
            container.RegisterType<ICacheService, CacheService>();
            container.RegisterType<IInstagramService, InstagramService>(new InjectionConstructor(new ResolvedParameter<ICacheService>()));
            container.RegisterType<ISocialIntegrationService, SocialIntegrationService>(new InjectionConstructor(new ResolvedParameter<IInstagramService>()));

            #region Controllers

            container.RegisterType<IControllerFactory, ControllerFactory>();

            container
                .RegisterController<PageController>()
                .RegisterController<HomeController>(new InjectionConstructor(new ResolvedParameter<ISocialIntegrationService>()))
                .RegisterController<CatalogController>()
                .RegisterController<AuthController>(new InjectionConstructor(new ResolvedParameter<ISocialIntegrationService>()))
                .RegisterController<GiveawayController>(new InjectionConstructor(new ResolvedParameter<ISocialIntegrationService>()));

            #endregion
        }
    }
}