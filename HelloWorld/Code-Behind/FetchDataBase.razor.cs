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

        protected override async Task OnInitializedAsync()
        {
            var httpClient = new HttpClient();

            //TODO: have to figure out a way to resolve URls in the code-behind.  Maybe server-side blazor handles this better???
            //This blog post might help:
            //https://benfoster.io/blog/injecting-urlhelper-in-aspnet-core-mvc
            forecasts = await httpClient.GetJsonAsync<WeatherForecast[]>("http://localhost:5000/sample-data/weather.json");
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