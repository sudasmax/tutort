using Tutort.SocialNetworks.Instagram.Models;

namespace Tutort.SocialNetworks.Instagram.Interfaces
{
    public interface IInstagramService
    {
        string AccessToken { get; set; }

        string ClientId { get; set; }
        Posts GetLatestPosts(int count);

        AccessTokenResponse GetAccessToken(string code, string clientId, string clientSecret, string redirectUrl);
    }
}
