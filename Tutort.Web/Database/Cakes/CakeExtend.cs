namespace Tutort.Web.Database.Cakes
{
	/// <summary>
	/// Relations for Cake entities and additional details for some categories of cakes.
	/// </summary>
	public class CakeExtend : DbEntity
	{
		public int CakeId { get; set; }
		public Cake Cake { get; set; }
	}
}