using System.Net.Http.Headers;
using MatchTraderBApi.Exceptions;
using MatchTraderBApi.Services;
using Microsoft.Extensions.DependencyInjection;
using Polly;

namespace MatchTraderBApi.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddMatchTraderBApi(this IServiceCollection services)
    {
        var retryPolicy = Policy<HttpResponseMessage>
            .Handle<MTrRequestException>()
            .Or<TimeoutException>()
            .OrResult(response => !response.IsSuccessStatusCode)
            .WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));

        var circuitBreakerPolicy = Policy<HttpResponseMessage>
            .Handle<MTrRequestException>()
            .Or<TimeoutException>()
            .OrResult(response => !response.IsSuccessStatusCode)
            .CircuitBreakerAsync(2, TimeSpan.FromSeconds(30));

        IAsyncPolicy<HttpResponseMessage> policyWrap = Policy.WrapAsync(retryPolicy, circuitBreakerPolicy);
        services.AddHttpClient<MTrBrokerApi>(client =>
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            })
            .AddPolicyHandler(policyWrap);
            
            
        return services;
    }
}