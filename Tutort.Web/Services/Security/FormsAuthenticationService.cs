using System;
using Tutort.Web.Models.Security;

namespace Tutort.Web.Services.Security
{
    public class FormsAuthenticationService : IAuthenticationService
    {
        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void Logout(User user)
        {
            throw new NotImplementedException();
        }
    }
}