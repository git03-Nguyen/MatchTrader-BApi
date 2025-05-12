using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Trading.TradingData;

public class MTrRetrieveClosedPositionsByLoginsOrGroupsRequest
{
    [JsonPropertyName("systemUuid")]
    public string SystemUuid { get; set; }

    [JsonPropertyName("logins")]
    public List<string> Logins { get; set; }

    [JsonPropertyName("groups")]
    public List<string> Groups { get; set; }

    [JsonPropertyName("from")]
    public DateTime From { get; set; }

    [JsonPropertyName("to")]
    public DateTime To { get; set; }

    [JsonPropertyName("includeLocked")]
    public bool? IsIncludeLocked { get; set; }

    [JsonPropertyName("includeBlocked")]
    public bool? IsIncludeBlocked { get; set; }

    [JsonPropertyName("limit")]
    public int? Limit { get; set; }
}