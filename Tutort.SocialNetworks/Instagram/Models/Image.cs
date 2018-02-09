using Newtonsoft.Json;

namespace Tutort.SocialNetworks.Instagram.Models
{
	[JsonObject(MemberSerialization.OptIn)]
	public class Image
	{
		[JsonProperty("height")]
		public int Height { get; set; }

		[JsonProperty("width")]
		public int Width { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }

	}
}
