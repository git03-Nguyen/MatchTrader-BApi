using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Trading.TradingData;

public class MTrRetrieveOpenPositionsByLoginsOrGroupsRequest
{
    [JsonPropertyName("systemUuid")]
    public string SystemUuid { get; set; }

    [JsonPropertyName("logins")]
    public IEnumerable<string>? Logins { get; set; }

    [JsonPropertyName("groups")]
    public IEnumerable<string>? Groups { get; set; }

    [JsonPropertyName("limit")]
    public int? Limit { get; set; }
}