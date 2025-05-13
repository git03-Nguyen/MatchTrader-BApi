using System.Text.Json.Serialization;
using MatchTraderBApi.Enums;

namespace MatchTraderBApi.Models.Requests.Trading.TradingData;

public class MTrRetrieveLedgersByLoginsOrGroupsRequest
{
    [JsonPropertyName("systemUuid")]
    public string SystemUuid { get; set; }

    [JsonPropertyName("types")]
    public IEnumerable<MTrLedgerType> Types { get; set; }

    [JsonPropertyName("logins")]
    public IEnumerable<string>? Logins { get; set; }

    [JsonPropertyName("groups")]
    public IEnumerable<string>? Groups { get; set; }

    [JsonPropertyName("from")]
    public DateTime? From { get; set; }

    [JsonPropertyName("to")]
    public DateTime? To { get; set; }

    [JsonPropertyName("limit")]
    public int? Limit { get; set; }
}