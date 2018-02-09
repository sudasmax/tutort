using Newtonsoft.Json;

namespace Tutort.SocialNetworks.Instagram.Models
{
    [JsonObject(MemberSerialization.OptIn)]
	public class AccessTokenResponse
	{
		[JsonProperty("access_token")]
		public string AccessToken { get; set; }

		[JsonProperty("user")]
		public User User { get; set; }
	}
}