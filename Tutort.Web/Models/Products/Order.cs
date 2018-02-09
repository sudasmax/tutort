namespace Tutort.Web.Models.Products
{
	public class Order : NamedEntity
	{
		public OrderStatus Status { get; set; }

		public bool Visible { get; set; }

	}
}