using Unity;

namespace Tutort.Web
{
    /// <summary>
    /// Gets Dependency Injection functionality
    /// </summary>
    internal static class IoC
    {
        private static IUnityContainer _container;

        /// <summary>
        /// DI container.
        /// </summary>
        public static IUnityContainer Container
        {
            get
            {
                return _container ?? (_container = new UnityContainer());
            }
        }

        /// <summary>
        /// Resoves type by DI container.
        /// </summary>
        /// <typeparam name="T">Type which should be resolved.</typeparam>
        /// <returns></returns>
        public static T Get<T>()
        {
            return Container.Resolve<T>();
        }
    }
}