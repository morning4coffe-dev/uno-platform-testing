using System.Collections.Immutable;
using UnoApp1.DataContracts;

namespace UnoApp1.Services.Caching
{
    public interface IWeatherCache
    {
        ValueTask<IImmutableList<WeatherForecast>> GetForecast(CancellationToken token);
    }
}