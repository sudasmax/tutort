using System.ComponentModel.DataAnnotations;

namespace Tutort.Web.Database
{
	public class DbEntity
	{
		[Key]
		public int Id { get; set; }
	}
}