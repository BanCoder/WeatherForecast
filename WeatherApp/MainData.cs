using Newtonsoft.Json;
namespace WeatherApp
{
	public class MainData
	{
		[JsonProperty("temp")]
		public float Temperature { get; set; }
		[JsonProperty("humidity")]
		public int Humidity { get; set; }
	}
}
