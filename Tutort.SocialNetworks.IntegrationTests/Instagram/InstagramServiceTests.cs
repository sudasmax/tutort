using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Tutort.Core.Caching.Interfaces;
using Tutort.SocialNetworks.Instagram.Interfaces;
using Tutort.SocialNetworks.Instagram.Services;

namespace Tutort.SocialNetworks.IntegrationTests
{
    [TestClass]
    public class InstagramServiceTests
    {
        private IInstagramService CreateInstagramService()
        {
            Mock<ICacheService> mockCacheService = new Mock<ICacheService>();
            IInstagramService service = new InstagramService(mockCacheService.Object);

            service.AccessToken = "296445302.cacd2a5.c4321e14519141d8a56fdb26f7c01e2f";
            service.ClientId = "3307bd4357a349169b6018322d95ed7d";

            return service;
        }

        [TestMethod]
        public void Instagram_GetLatestPosts_Success()
        {
            // Arrange
            var service = this.CreateInstagramService();

            // Act
            var posts = service.GetLatestPosts(3);

            // Assert
            Assert.IsNotNull(posts, "Service should return three latest posts.");
            Assert.IsNotNull(posts.Data);
            Assert.AreEqual(3, posts.Data.Length, "Expected three latest posts.");
        }

        [TestMethod]
        public void Instagram_GetAccessToken_Success()
        {
            // Arrange
            var service = this.CreateInstagramService();
            service.AccessToken = null;
            var clientId = "cacd2a533d4346ccbad40abb7beb9f37";
            var clientSecret = "3307bd4357a349169b6018322d95ed7d";
            var redirectUrl = "http://localhost:100/auth";

            // Act
            service.GetAccessToken(null, clientId, clientSecret, redirectUrl);

            // Assert
            Assert.IsNotNull(service.AccessToken);
        }
    }
}
