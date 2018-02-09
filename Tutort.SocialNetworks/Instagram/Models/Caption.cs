using System;
using Newtonsoft.Json;
using Tutort.SocialNetworks.Json;

namespace Tutort.SocialNetworks.Instagram.Models
{
	[JsonObject(MemberSerialization.OptIn)]
	public class Caption
	{
		[JsonConverter(typeof(DateTimePropertyConverter))]
		[JsonProperty("created_time")]
		public DateTime CreatedTime { get; set; }

		[JsonProperty("from")]
		public User From { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("text")]
		public string Text { get; set; }
	}
}
