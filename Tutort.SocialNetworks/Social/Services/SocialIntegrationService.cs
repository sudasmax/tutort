using Tutort.SocialNetworks.Instagram.Interfaces;
using Tutort.SocialNetworks.Social.Interfaces;

namespace Tutort.SocialNetworks.Social.Services
{
	public class SocialIntegrationService : ISocialIntegrationService
	{
		private readonly IInstagramService instagramService;

		public SocialIntegrationService(IInstagramService instagramService)
		{
			this.instagramService = instagramService;
		}

		public IInstagramService GetInstagramService()
		{
			return instagramService;
		}
	}
}
