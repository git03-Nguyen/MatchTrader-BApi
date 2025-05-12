namespace MatchTraderBApi.Options;

public class MTrSettingsOptions
{
    public string RestHost { get; set; } = string.Empty;
    public string gRpcHost { get; set; } = string.Empty;
    public string ApiKey { get; set; } = string.Empty;
    public string SystemUuid { get; set; } = string.Empty;
    public string ApiVersion { get; set; } = string.Empty;
    
    public int TimeZone { get; set; } = 0;
    public int Timeout { get; set; } = 30000;
}

