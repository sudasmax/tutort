using System;
using Newtonsoft.Json;

namespace Tutort.SocialNetworks.Json
{
	public class DateTimePropertyConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			return true;
		}

		private DateTime UnixTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var value = reader.Value.ToString();
			return UnixTime.AddSeconds(double.Parse(value)).ToLocalTime();
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw new NotImplementedException();
		}
	}
}
