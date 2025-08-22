using System;
using Newtonsoft.Json; 
namespace WeatherApp
{
	internal class MainData
	{
		[JsonProperty("temp")]
		public float Temperature { get; set; }
		[JsonProperty("humidity")]
		public int Humidity { get; set; }
	}
}
