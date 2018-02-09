using System.Collections.Generic;

namespace Tutort.Web.Database.Cakes.Biscuit
{
	public class BiscuitCake : CakeExtend
	{
		public virtual ICollection<BiscuitType> BiscuitTypes { get; set; }

		public virtual ICollection<BiscuitCreamType> BiscuitCreamTypes { get; set; }

		public virtual ICollection<BiscuitFillingType> BiscuitFillingTypes { get; set; }

		//	public int BiscuitTypeId { get; set; }
		//public BiscuitType BiscuitType { get; set; }

		//public int CreamTypeId { get; set; }
		//public BiscuitCreamType CreamType { get; set; }

		//public int FillingTypeId { get; set; }
		//public BiscuitFillingType FillingType { get; set; }
	}
}