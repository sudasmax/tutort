using System;
using System.ComponentModel.DataAnnotations;

namespace Tutort.Web.Database.Promotion
{
	public class Promo
	{
		[Key]
		[DataType(DataType.Date)]
		public DateTime Date { get; set; }

		public string Name { get; set; }
		public string Description { get; set; }
	}
}