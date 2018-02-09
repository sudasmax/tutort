using System.Configuration;
using System.Web.Mvc;
using System.Web.Routing;
using Tutort.SocialNetworks.Social.Interfaces;

namespace Tutort.Web.Controllers
{
    public class AuthController : ControllerBase
    {
        private ISocialIntegrationService socialIntegrationService;

        public AuthController(ISocialIntegrationService socialIntegrationService)
        {
            this.socialIntegrationService = socialIntegrationService;
        }

        [AllowAnonymous]
        public void Login()
        {
            var clientId = ConfigurationManager.AppSettings["Instagram.ClientId"].ToString();
            var redirectUri = this.Url.Action("Auth", "Auth", null, HttpContext.Request.Url.Scheme);

            var url = string.Format("https://api.instagram.com/oauth/authorize/?client_id={0}&redirect_uri={1}&response_type=code",
                clientId,
                redirectUri);

            Response.Redirect(url);
        }

        [AllowAnonymous]
        public void Auth(string code)
        {
            var clientId = ConfigurationManager.AppSettings["Instagram.ClientId"].ToString();
            var clientSecret = ConfigurationManager.AppSettings["Instagram.ClientSecret"].ToString();
            var redirectUrl = this.Url.Action("Auth", "Auth", null, HttpContext.Request.Url.Scheme);

            var instagramService = this.socialIntegrationService.GetInstagramService();
            instagramService.GetAccessToken(code, clientId, clientSecret, redirectUrl);
            var token = instagramService.AccessToken;

            var a = token;
        }
    }
}