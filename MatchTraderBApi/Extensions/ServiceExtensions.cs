using System.Net.Http.Headers;
using MatchTraderBApi.Options;
using MatchTraderBApi.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Polly.Extensions.Http;

namespace MatchTraderBApi.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddMatchTraderBApi(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<MTrBrokerPolicyOptions>(configuration.GetSection(MTrBrokerPolicyOptions.OptionName));
        
        services.AddHttpClient<MTrBrokerApi>(client =>
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        })
        .AddPolicyHandler((_, _) =>
        {
            var options = configuration
                .GetSection(MTrBrokerPolicyOptions.OptionName)
                .Get<MTrBrokerPolicyOptions>() ?? new();

            // Retry policy
            IAsyncPolicy<HttpResponseMessage> retryPolicy = options.EnableRetry
                ? HttpPolicyExtensions
                    .HandleTransientHttpError()
                    .Or<TaskCanceledException>()
                    .WaitAndRetryAsync(
                        retryCount: options.RetryCount,
                        sleepDurationProvider: retryAttempt =>
                            TimeSpan.FromSeconds(Math.Pow(options.RetryBaseDelaySeconds, retryAttempt))
                    )
                : Policy.NoOpAsync<HttpResponseMessage>();

            // Circuit breaker policy
            IAsyncPolicy<HttpResponseMessage> circuitBreakerPolicy = options.EnableCircuitBreaker
                ? HttpPolicyExtensions
                    .HandleTransientHttpError()
                    .Or<TaskCanceledException>()
                    .CircuitBreakerAsync(
                        handledEventsAllowedBeforeBreaking: options.CircuitBreakerFailures,
                        durationOfBreak: TimeSpan.FromSeconds(options.CircuitBreakerDurationSeconds)
                    )
                : Policy.NoOpAsync<HttpResponseMessage>();

            // Combine both if needed
            return Policy.WrapAsync(circuitBreakerPolicy, retryPolicy);
        });
            
        return services;
    }
}