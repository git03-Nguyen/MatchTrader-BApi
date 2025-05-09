using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.General;

public class MTrRetrievePlatformLogsV2Request
{
    [JsonPropertyName("accountUuidFilter")]
    public string AccountUuid { get; set; }

    [JsonPropertyName("accountEmailFilter")]
    public string AccountEmail { get; set; }

    [JsonPropertyName("tradingAccountUuidFilter")]
    public string TradingAccountUuid { get; set; }

    [JsonPropertyName("tradingAccountLoginFilter")]
    public string TradingAccountLogin { get; set; }

    [JsonPropertyName("clientIpFilter")]
    public string ClientIp { get; set; }

    [JsonPropertyName("browserIdFilter")]
    public string BrowserId { get; set; }

    [JsonPropertyName("levelFilter")]
    public string Level { get; set; }

    [JsonPropertyName("eventFilter")]
    public string Event { get; set; }

    [JsonPropertyName("countryFilter")]
    public string Country { get; set; }

    [JsonPropertyName("appVersionFilter")]
    public string AppVersion { get; set; }

    [JsonPropertyName("appTypeFilter")]
    public string AppType { get; set; }

    [JsonPropertyName("deviceTypeFilter")]
    public string DeviceType { get; set; }

    [JsonPropertyName("viewFilter")]
    public string View { get; set; }

    [JsonPropertyName("userAgentFilter")]
    public string UserAgent { get; set; }

    [JsonPropertyName("appResolutionFilter")]
    public string AppResolution { get; set; }
}