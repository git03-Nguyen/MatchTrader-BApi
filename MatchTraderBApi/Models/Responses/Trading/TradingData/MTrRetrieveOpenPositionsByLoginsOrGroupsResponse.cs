using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos.Trading;

namespace MatchTraderBApi.Models.Responses.Trading.TradingData;

public class MTrRetrieveOpenPositionsByLoginsOrGroupsResponse
{
    [JsonPropertyName("login")]
    public ulong Login { get; set; }
    
    [JsonPropertyName("group")]
    public string Group { get; set; }
    
    [JsonPropertyName("positions")]
    public List<MTrOpenPosition> Positions { get; set; }
}