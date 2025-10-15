using Newtonsoft.Json;
namespace WeatherApp
{
	internal class WeatherData
	{
		[JsonProperty("name")]
		public string CityName { get; set; }
		[JsonProperty("main")]
		public MainData Main { get; set; }
		[JsonProperty("weather")]
		public WeatherDescription[] Weather { get; set; }
		[JsonProperty("wind")]
		public WindData Wind { get; set; }
	}
}
