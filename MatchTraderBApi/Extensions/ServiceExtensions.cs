using System.Net.Http.Headers;
using MatchTraderBApi.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MatchTraderBApi.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddMatchTraderBApi(this IServiceCollection services)
    {
        services.AddHttpClient(nameof(MTrBrokerApi), client =>
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        });

        return services;
    }
}