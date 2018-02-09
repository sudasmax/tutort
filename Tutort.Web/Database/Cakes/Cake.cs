using System.Collections.Generic;
using Tutort.Web.Database.Cakes.Biscuit;
using Tutort.Web.Database.Cakes.Honey;

namespace Tutort.Web.Database.Cakes
{
	public class Cake : DbEntity
	{
		public int BiscuitCakeId { get; set; }
		public BiscuitCake BiscuitCake { get; set; }

		public int HoneyCakeId { get; set; }
		public HoneyCake HoneyCake { get; set; }

		public virtual ICollection<Order> Orders { get; set; }
	}
}