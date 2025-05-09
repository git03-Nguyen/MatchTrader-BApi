using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Trading.TradingData;

public class GetMTrGroupsRequest
{
    [JsonPropertyName("names")]
    public List<string> Names { get; set; }
}