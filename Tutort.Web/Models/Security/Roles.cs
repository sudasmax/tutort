namespace Tutort.Web.Models.Security
{
	public enum Roles
	{
		Anonymous = 0,
		BlockedUser = 1,
		ReadOnlyUser = 2,
		User = 4,
		PowerUser = 8,
		Manager = 16,
		Admin = 32,
		All = Anonymous | BlockedUser | ReadOnlyUser | User | PowerUser | Manager | Admin
	}
}