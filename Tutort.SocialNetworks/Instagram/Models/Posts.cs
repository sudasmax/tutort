using Newtonsoft.Json;

namespace Tutort.SocialNetworks.Instagram.Models
{
	[JsonObject(MemberSerialization.OptIn)]
	public class Posts
	{
		[JsonProperty("data")]
		public PostData[] Data { get; set; }

		[JsonProperty("meta")]
		public Meta Metadata { get; set; }
	}
}
