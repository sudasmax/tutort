using System.Collections.Generic;

namespace Tutort.Web.Database.Cakes.Biscuit
{
	public class BiscuitFillingType : DbNamedEntity
	{
		public ICollection<BiscuitCake> BiscuitCakes { internal get; set; }
	}
}