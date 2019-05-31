using System;
using System.Net;
using System.Net.Http;
// using System.Net.Http;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace HelloWorldBlazor
{
    public class FetchDataBase : ComponentBase
    {
        public WeatherForecast[] forecasts;

        protected override async Task OnInitAsync()
        {
            var httpClient = new HttpClient();
            forecasts = await httpClient.GetJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }

        public class WeatherForecast
        {
            public DateTime Date { get; set; }

            public int TemperatureC { get; set; }

            public int TemperatureF { get; set; }

            public string Summary { get; set; }
        }
    }
}