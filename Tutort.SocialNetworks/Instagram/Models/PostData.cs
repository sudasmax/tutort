using System;
using Newtonsoft.Json;
using Tutort.SocialNetworks.Json;

namespace Tutort.SocialNetworks.Instagram.Models
{
	[JsonObject(MemberSerialization.OptIn)]
	public class PostData
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("user")]
		public User User { get; set; }

		[JsonProperty("likes")]
		public CountObject Likes { get; set; }

		[JsonProperty("comments")]
		public CountObject Comments { get; set; }

		[JsonProperty("images")]
		public Images ImageList { get; set; }

		[JsonConverter(typeof(DateTimePropertyConverter))]
		[JsonProperty("created_time")]
		public DateTime CreatedTime { get; set; }

		[JsonProperty("link")]
		public string Link { get; set; }

		[JsonProperty("caption")]
		public Caption Caption { get; set; }
	}
}