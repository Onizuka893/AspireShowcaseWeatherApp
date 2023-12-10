using WeatherApi.Web.Components.Pages;

namespace WeatherApp.Api;

public class WeatherApiClient
{
    private readonly HttpClient _client;

    public WeatherApiClient(HttpClient client)
    {
        _client = client;
    }

    public async Task<Weather.WeatherForecast[]> GetWeatherAsync()
    {
        return await _client.GetFromJsonAsync<Weather.WeatherForecast[]>("weatherforecast") ?? [];
    }
}
