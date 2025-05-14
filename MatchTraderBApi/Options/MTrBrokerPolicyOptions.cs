namespace MatchTraderBApi.Options;

public class MTrBrokerPolicyOptions
{
    public static string OptionName = "MTrBrokerPolicy";
    
    public bool EnableCircuitBreaker { get; set; } = false;
    public bool EnableRetry { get; set; } = false;
    
    public int RetryCount { get; set; } = 3;
    public int RetryBaseDelaySeconds { get; set; } = 2;
    public int CircuitBreakerFailures { get; set; } = 2;
    public int CircuitBreakerDurationSeconds { get; set; } = 30;
}