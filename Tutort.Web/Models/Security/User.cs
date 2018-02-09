namespace Tutort.Web.Models.Security
{
    public class User
    {
        public bool IsAdministrator { get; set; }
        public Roles Permissions { get; set; }
    }
}