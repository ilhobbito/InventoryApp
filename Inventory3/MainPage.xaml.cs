using Inventory3.ViewModels;

namespace Inventory3
{
    //Fick inte med singelton i min app.
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new WeatherDataViewModels().Weather;
            var task = Task.Run(() => WeatherDataViewModels.GetWeatherAsync("Nyköping"));
            task.Wait();
            var weather = task.Result;
            Temp.Text = weather.temp.ToString();
            CloudPct.Text = weather.cloud_pct.ToString();
            FeelsLike.Text = weather.feels_like.ToString();
            Humidity.Text = weather.humidity.ToString();
            MinTemp.Text = weather.min_temp.ToString();
            MaxTemp.Text = weather.max_temp.ToString();
            //WindSpeed.Text = weather.wind_speed.ToString();
            //WindDegrees.Text = weather.wind_degrees.ToString();
            //Sunrise.Text = weather.sunrise.ToString();
            //Sunset.Text = weather.sunset.ToString();
        }

        private async void ClickedOnFridge(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Fridge(null));
        }

        private async void ClickedOnFreezer(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Freezer(null));
        }

        private async void ClickedOnPantry(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Pantry(null));
        }

        private async void ClickedOnInventoryAdmin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.InventoryAdmin(null));
        }
    }

}
