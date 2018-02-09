using Newtonsoft.Json;

namespace Tutort.SocialNetworks.Instagram.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class User
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("profile_picture")]
        public string ProfilePictureUrl { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("is_business")]
        public bool IsBusiness { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }
    }
}
