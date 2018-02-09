using System.Collections.Generic;

namespace Tutort.Web.Database.Cakes.Biscuit
{
	public class BiscuitCreamType : DbNamedEntity
	{
		public ICollection<BiscuitCake> BiscuitCakes { internal get; set; }
	}
}