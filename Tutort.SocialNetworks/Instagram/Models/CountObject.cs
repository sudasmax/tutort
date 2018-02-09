using Newtonsoft.Json;

namespace Tutort.SocialNetworks.Instagram.Models
{
	[JsonObject(MemberSerialization.OptIn)]
	public class CountObject
	{
		[JsonProperty("count")]
		public int Count { get; set; }
	}
}
