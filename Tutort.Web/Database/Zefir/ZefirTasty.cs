using System.Collections.Generic;

namespace Tutort.Web.Database.Zefir
{
	public class ZefirTasty : DbNamedEntity
	{
		public virtual ICollection<Zefir> ZefirCollection { get; set; }
	}
}