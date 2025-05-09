using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Trading.TradingData;

public class MTrGetGroupsRequest
{
    [JsonPropertyName("names")]
    public List<string> Names { get; set; }
}