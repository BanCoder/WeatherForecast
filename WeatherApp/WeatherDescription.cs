using System;
using Newtonsoft.Json;
namespace WeatherApp
{
	internal class WeatherDescription
	{
		[JsonProperty("main")]
		public string Main { get; set; }
		[JsonProperty("description")]
		public string Description { get; set; }
		[JsonProperty("icon")]
		public string Icon { get; set; }
	}
}
