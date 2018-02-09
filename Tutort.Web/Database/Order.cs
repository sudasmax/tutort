using System;
using System.Collections.Generic;
using Tutort.Web.Database.Cakes;

namespace Tutort.Web.Database
{
	public class Order : DbEntity
	{
		public decimal Price { get; set; }

		public DateTime? OrderDate { get; set; }
		public DateTime? OrderBeginDate { get; set; }

		public string Description { get; set; }

		public virtual ICollection<Cake> Cakes { get; set; }

		public virtual ICollection<Zefir.Zefir> Zefir { get; set; }
	}
}