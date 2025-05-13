using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Trading.TradingData;

public class MTrGetGroupsRequest
{
    [JsonPropertyName("names")]
    public IEnumerable<string> Names { get; set; }
}