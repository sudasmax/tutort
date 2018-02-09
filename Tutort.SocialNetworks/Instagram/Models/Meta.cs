using Newtonsoft.Json;

namespace Tutort.SocialNetworks.Instagram.Models
{
	[JsonObject(MemberSerialization.OptIn)]
	public class Meta
	{
		[JsonProperty("code")]
		public int Code { get; set; }

		[JsonProperty("error_type")]
		public string ErrorType { get; set; }

		[JsonProperty("error_message")]
		public string ErrorMessage { get; set; }
	}
}
