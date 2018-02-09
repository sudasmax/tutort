using Newtonsoft.Json;

namespace Tutort.SocialNetworks.Instagram.Models
{
	[JsonObject(MemberSerialization.OptIn)]
	public class Post
	{
		[JsonProperty("data")]
		public PostData Data { get; set; }

		[JsonProperty("meta")]
		public Meta Metadata { get; set; }
	}
}
