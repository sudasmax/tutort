using Tutort.SocialNetworks.Instagram.Interfaces;

namespace Tutort.SocialNetworks.Social.Interfaces
{
	public interface ISocialIntegrationService
	{
		IInstagramService GetInstagramService();
	}
}
