namespace Tutort.Web.Models.Security
{
    public class UserSession
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public bool IsAdministrator { get; set; }
        public Roles GetRoles()
        {
            // make the call to the database or whatever here.
            // or just turn this into a property.
            return Roles.Anonymous;
        }
    }
}