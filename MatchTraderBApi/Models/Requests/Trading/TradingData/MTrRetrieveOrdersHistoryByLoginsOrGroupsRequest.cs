using System.Text.Json.Serialization;
using MatchTraderBApi.Enums.Trading;

namespace MatchTraderBApi.Models.Requests.Trading.TradingData;

internal class MTrRetrieveOrdersHistoryByLoginsOrGroupsRequest
{
    [JsonPropertyName("systemUuid")]
    public string SystemUuid { get; set; }

    [JsonPropertyName("statuses")]
    public IEnumerable<MTrOrderStatus> Statuses { get; set; }

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