namespace MatchTraderBApi.Options;

public interface IMTrSettingsOptions
{
    string RestHost { get; set; }
    string gRpcHost { get; set; }
    string ApiKey { get; set; }
    string SystemUuid { get; set; }
    string ApiVersion { get; set; }
    int TimeZone { get; set; }
    int Timeout { get; set; }
}

