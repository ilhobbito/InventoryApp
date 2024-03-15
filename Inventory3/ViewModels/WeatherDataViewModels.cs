using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Inventory3.ViewModels
{
    public class WeatherDataViewModels
    {
        public Models.Weather Weather { get; set; }

        public WeatherDataViewModels()
        {
            
            var task = Task.Run(() => InitializeWeatherAsync());
            task.Wait();
            //Weather.AddRange(task.Result);
        }

        public async void InitializeWeatherAsync()
        {
            Weather = await GetWeatherAsync("Nyköping");
        }
        public static async Task<Models.Weather> GetWeatherAsync(string cityName)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.api-ninjas.com/");
            client.DefaultRequestHeaders.Add("X-Api-Key", "pCKeYmBxm0rhAA1nkemWCw==OIGBh8O0sYv49zm2");

            Models.Weather? weather = new Models.Weather();
           
                HttpResponseMessage response = await client.GetAsync($"v1/weather/?city={cityName}");
                if (response.IsSuccessStatusCode)
                {
                    string responseString = await response.Content.ReadAsStringAsync();
                    weather = JsonSerializer.Deserialize<Models.Weather>(responseString);
                }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Problem med att hitta väderdata: {ex.Message}");
            //}
            //finally
            //{
            //    client.Dispose();
            //}
            return weather;
        }
    }

}
