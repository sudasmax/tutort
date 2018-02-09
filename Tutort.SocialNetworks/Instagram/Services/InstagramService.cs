using System;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using Tutort.Core.Caching.Interfaces;
using Tutort.Core.Helpers;
using Tutort.SocialNetworks.Http;
using Tutort.SocialNetworks.Instagram.Interfaces;
using Tutort.SocialNetworks.Instagram.Models;

namespace Tutort.SocialNetworks.Instagram.Services
{
    public class InstagramService : IInstagramService
    {
        private ICacheService CacheService { get; }

        public InstagramService(ICacheService cacheService)
        {
            Guard.ArgumentNotNull(cacheService, "cacheService");

            this.CacheService = cacheService;
        }

        public string AccessToken { get; set; }

        public string ClientId { get; set; }

        [Obsolete("Should be removed")]
        public void GetPost(string mediaId, Action<Post> callback)
        {
            Guard.ArgumentNotNullOrEmpty(mediaId, "mediaId");
            Guard.ArgumentNotNull(callback, "callback");

            var url =string.Format("https://api.instagram.com/v1/media/{0}?access_token={1}", mediaId, AccessToken);

            TutortHttpClient.GetResponse(url, callback);
        }

        [Obsolete("Should be removed")]
        public void GetComments(string mediaId, Action<Post> callback)
        {
            Guard.ArgumentNotNullOrEmpty(mediaId, "mediaId");
            Guard.ArgumentNotNull(callback, "callback");

            var url = string.Format("https://api.instagram.com/v1/media/{0}/comments?access_token={1}", mediaId, AccessToken);

            TutortHttpClient.GetResponse(url, callback);
        }

        public Posts GetLatestPosts(int count)
        {
            const string cacheKey = "InstagramService.LatestPosts";

            var posts = this.CacheService.Get<Posts>(cacheKey);

            if (posts == null || posts.Data == null || posts.Data.Length < count)
            {
                posts = RetrieveLatestPostsFromInstagram(count);

                if (posts != null && posts.Data != null)
                {
                    this.CacheService.Set<Posts>(cacheKey, posts, 60);
                }
            }

            if (posts != null && posts.Data != null)
            {
                posts.Data = posts.Data.Take(count).ToArray();
            }

            return posts;
        }

        private Posts RetrieveLatestPostsFromInstagram(int count)
        {
            var url = string.Format("https://api.instagram.com/v1/users/self/media/recent/?access_token={0}&count={1}", AccessToken, count);

            //var tutortUserId = "tutort.by";
            //var url = string.Format("https://api.instagram.com/v1/users/{0}/media/recent/?client_id={1}&count={2}", tutortUserId, this.ClientId, count);
            return TutortHttpClient.GetResponse<Posts>(url);
        }

        public AccessTokenResponse GetAccessToken(string code, string clientId, string clientSecret, string redirectUrl)
        {
            var url = "https://api.instagram.com/oauth/access_token";

            NameValueCollection parameters = new NameValueCollection
            {
                { "client_id", clientId },
                { "client_secret", clientSecret },
                { "grant_type", "authorization_code" },
                { "redirect_uri", redirectUrl },
                { "code", code }
            };

            using (WebClient client = new WebClient())
            {
                return TutortHttpClient.GetPostResponse<AccessTokenResponse>(url, parameters);
            }
        }
    }

    //public class InstagramOAuthResponse
    //{
    //    public string access_token { get; set; }
    //    public User user { get; set; }
    //}

    //public class User : System.Security.Principal.IIdentity
    //{
    //    public string username { get; set; }
    //    public string website { get; set; }
    //    public string profile_picture { get; set; }
    //    public string full_name { get; set; }
    //    public string bio { get; set; }
    //    public string id { get; set; }

    //    public string OAuthToken { get; set; }

    //    public string AuthenticationType
    //    {
    //        get { return "Instagram"; }
    //    }

    //    public bool IsAuthenticated
    //    {
    //        get { return !string.IsNullOrEmpty(id); }
    //    }

    //    public string Name
    //    {
    //        get
    //        {
    //            return String.IsNullOrEmpty(full_name) ? "unknown" : full_name;
    //        }
    //    }
    //}
}
