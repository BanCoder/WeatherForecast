using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
namespace WeatherApp
{
	internal class Requester
	{
		private const string _apiKey = "3972a0d14725ca68d81f58d5ed724f47";
		private const string _baseUrl = "https://api.openweathermap.org/data/2.5/weather";
		public async Task<WeatherData> GetWeatherDataAsync(string cityName)
		{
			string requestUrl = $"{_baseUrl}?q={cityName}&appid={_apiKey}&units=metric&lang=ru";
			HttpClient httpClient = new HttpClient();
			try
			{
				HttpResponseMessage response = await httpClient.GetAsync(requestUrl);
				response.EnsureSuccessStatusCode(); 
				string responseBody = await response.Content.ReadAsStringAsync();
				WeatherData weatherData = Newtonsoft.Json.JsonConvert.DeserializeObject<WeatherData>(responseBody);
				return weatherData;
			}
			catch (HttpRequestException ex)
			{
				MessageBox.Show($"Ошибка при получении запроса к API: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null; 
			}
		}
	}
}
