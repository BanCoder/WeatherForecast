using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WeatherApp
{
	internal class Requester
	{
		private  string _apiKey = App.Settings.ApiKey;
		private string _baseUrl = App.Settings.BaseUrl; 
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
