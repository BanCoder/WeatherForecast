using System;
using Newtonsoft.Json; 
namespace WeatherApp
{
	public class WindData
	{
		[JsonProperty("speed")]
		public double Speed;
	}
}
