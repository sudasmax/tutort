using System.Collections.Generic;

namespace Tutort.Web.Database.Zefir
{
	public class Zefir : DbEntity
	{
		public ZefirTasty Tasty { get; set; }

		public virtual ICollection<Order> Orders { get; set; }
	}
}