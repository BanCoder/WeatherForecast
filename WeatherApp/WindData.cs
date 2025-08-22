using System;
using Newtonsoft.Json; 
namespace WeatherApp
{
	internal class WindData
	{
		[JsonProperty("speed")]
		public double Speed;
	}
}
