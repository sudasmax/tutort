using Newtonsoft.Json;

namespace Tutort.SocialNetworks.Instagram.Models
{
	[JsonObject(MemberSerialization.OptIn)]
	public class Images
	{
		[JsonProperty("low_resolution")]
		public Image LowResolution { get; set; }

		[JsonProperty("standard_resolution")]
		public Image StandardResolution { get; set; }

		[JsonProperty("thumbnail")]
		public Image Thumbnail { get; set; }
	}
}
