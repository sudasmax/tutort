namespace Tutort.Web.Models
{
	public class NamedEntity : IIdentifier
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }
		
	}
}