//using System;
//using System.Linq.Expressions;
//using System.Web;
//using System.Web.Mvc;
//using System.Web.Routing;
//using Microsoft.Practices.Unity.Utility;
//using Microsoft.Web.Mvc;
//using Tutort.Web.Extensions;

//namespace Tutort.Web.Services
//{
//    /// <summary>
//    /// Link builder.
//    /// </summary>
//    public class LinkBuilderService : ILinkBuiderService
//    {
//        /// <summary>
//        /// Creates url.
//        /// </summary>
//        /// <typeparam name="TController">Controller which is used in action.</typeparam>
//        /// <param name="action">Action.</param>
//        /// <param name="values">Additional parameters to url.</param>
//        /// <returns>Url.</returns>
//        public string GetUrl<TController>(Expression<Action<TController>> action, RouteValueDictionary values) where TController : Controller
//        {
//            Guard.ArgumentNotNull(action, "action");

//            var parameters = RetrieveRouteValueDictionary(action);

//            if (values != null)
//            {
//                parameters = parameters.MergeRouteValues(values);
//            }

//            return RouteTable.Routes.GetVirtualPath(HttpContext.Current.Request.RequestContext, parameters).VirtualPath;

//            throw new NotImplementedException();
//        }

//        /// <summary>
//        /// Retrieves <see cref="RouteValueDictionary"> from Controller and Action.
//        /// </summary>
//        /// <typeparam name="TController">Controller which is used in action.</typeparam>
//        /// <param name="action">Action.</param>
//        /// <returns><see cref="RouteValueDictionary"> collection.</returns>
//        private RouteValueDictionary RetrieveRouteValueDictionary<TController>(Expression<Action<TController>> action)
//        {
//            Guard.ArgumentNotNull(action, "action");

//            MethodCallExpression body = action.Body as MethodCallExpression;
//            if (body == null)
//            {
//                throw new InvalidOperationException("Expression must be a method call.");
//            }

//            if (body.Object != action.Parameters[0])
//            {
//                throw new InvalidOperationException("Method call must target lambda argument.");
//            }

//            string actionName = body.Method.Name;
//            string controllerName = typeof(TController).Name;

//            if (controllerName.EndsWith("Controller", StringComparison.OrdinalIgnoreCase))
//            {
//                controllerName = controllerName.Remove(controllerName.Length - 10, 10);
//            }

//            RouteValueDictionary parameters = LinkBuilder.BuildParameterValuesFromExpression(body);

//            parameters.Add("controller", controllerName);
//            parameters.Add("action", actionName);

//            return parameters;
//        }
//    }
//}