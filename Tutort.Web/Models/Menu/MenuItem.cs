using System.Linq;
using Tutort.Web.Models.Security;

namespace Tutort.Web.Models.Menu
{
	public class MenuItem
	{
		public string Text { get; set; }

		public string ActionName { get; set; }

		public string ControllerName { get; set; }

		public MenuItem[] Submenu { get; set; }

		public Roles Access { get; set; }

		public MenuItem Parent { get; set; }

		public MenuItem(string text, string action, string controller, params MenuItem[] submenu)
		{
			this.Text = text;
			this.ActionName = action;
			this.ControllerName = controller;
			this.Access = Roles.Anonymous;

			Submenu = submenu;

			if (submenu != null)
			{
				foreach (var item in Submenu)
					item.Parent = this;
			}
		}

		public static MenuItem Find(MenuItem item, string action, string controller)
		{
			return item != null
				? item.ActionName.Equals(action, System.StringComparison.OrdinalIgnoreCase) && item.ControllerName.Equals(controller, System.StringComparison.OrdinalIgnoreCase)
					? item
					: item.Submenu != null ? item.Submenu.Select(x => Find(x, action, controller)).FirstOrDefault(x => x != null) : null
				: null;
		}
	}
}