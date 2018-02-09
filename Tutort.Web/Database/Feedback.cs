using System;

namespace Tutort.Web.Database
{
	public class Feedback : DbEntity
	{
		public User User { get; set; }
		public DateTime Date { get; set; }
		public Order Order { get; set; }
	}
}