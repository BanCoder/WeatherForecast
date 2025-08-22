using System;
using System.Windows.Forms;

namespace WeatherApp
{
	public partial class WeatherForecast : Form
	{
		Requester _requester; 
		public WeatherForecast()
		{
			_requester = new Requester();
			InitializeComponent();
		}
		private async void weatherSearchBtn_Click(object sender, EventArgs e)
		{
			string cityName = cityNameTxt.Text.Trim();
			if (string.IsNullOrEmpty(cityName))
			{
				MessageBox.Show("Вы не ввели название города!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return; 
			}
			weatherSearchBtn.Enabled = false;
			weatherSearchBtn.Text = "Загрузка...";
			WeatherData data = await _requester.GetWeatherDataAsync(cityName);
			weatherSearchBtn.Enabled = true;
			weatherSearchBtn.Text = "Узнать погоду";
			if (data != null)
			{
				DisplayWeatherData(data); 
			}
			else
			{
				MessageBox.Show("Данные о погоде не были получены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void DisplayWeatherData(WeatherData data)
		{
			displayCityName.Text = data.CityName;
			displayTemperature.Text = $"{data.Main.Temperature} °C";
			displayDescription.Text = data.Weather[0].Description;
			displayHumidity.Text = $"{data.Main.Humidity} %";
			displayWindSpeed.Text = $"{data.Wind.Speed} м/с";

			string iconCode = data.Weather[0].Icon;
			string iconUrl = $"http://openweathermap.org/img/wn/{iconCode}@2x.png";
			try
			{
				weatherIcon.Load(iconUrl);
			}
			catch(Exception ex)
			{
				MessageBox.Show($"Ошибка загрузки иконки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			}
			
		}
	}
}
