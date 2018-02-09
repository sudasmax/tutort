using System.Web.Mvc;
using Tutort.Web.ViewModels.Page;

namespace Tutort.Web.Extensions
{
    public static class HtmlHelperExtensions
    {
        private static string cssClass = "active";

        public static string IsSelected(this HtmlHelper html, string controller = null, string action = null)
        {
            string currentAction = (string)html.ViewContext.RouteData.Values["action"];
            string currentController = (string)html.ViewContext.RouteData.Values["controller"];

            if (string.IsNullOrEmpty(controller))
                controller = currentController;

            if (string.IsNullOrEmpty(action))
                action = currentAction;

            return controller == currentController && action == currentAction ?
                cssClass : string.Empty;
        }

        public static string IsSelected(this HtmlHelper html, bool isSelected)
        {
            return isSelected ? cssClass : string.Empty;
        }

        public static MvcHtmlString ToNavigationMenu(this HeadLineViewModel viewModel, string separator)
        {
            var result = viewModel != null && viewModel.NavigationMenuItems != null
                ? string.Join(separator, viewModel.NavigationMenuItems)
                : string.Empty;

            return new MvcHtmlString(result);
        }

        //public static string MakeLink<TController>(this TController controller, Expression<Action<TController>> action, string title) where TController : Controller
        //{
        //    return string.Format("<a href=\"{0}\">{1}</a>",
        //        controller.Url.Action(,
        //        title);
        //}

        //public static MvcHtmlString GetNavigationMenu(this HtmlHelper html)
        //{
        //	var action = html.ViewContext.RouteData.GetRequiredString("action");
        //	var controller = html.ViewContext.RouteData.GetRequiredString("controller");

        //	var menuItem = MenuItem.Find(NavigationMapConfig.Map, action, controller);

        //	return menuItem != null
        //		? new MvcHtmlString(html.GetNavigationMenu(menuItem, true))
        //		: new MvcHtmlString(string.Empty);
        //}

        //private static string GetNavigationMenu(this HtmlHelper html, MenuItem item, bool isCurrent = false)
        //{
        //	Guard.ArgumentNotNull(html, "html");

        //	if (item != null)
        //	{
        //		var link = isCurrent ? item.Text : html.ActionLink(item.Text, item.ActionName, item.ControllerName).ToString();
        //		var result = item.Parent != null
        //			? string.Format("{0} / {1}", html.GetNavigationMenu(item.Parent), link)
        //			: link.ToString();

        //		return result;
        //	}

        //	return null;
        //}
    }
}