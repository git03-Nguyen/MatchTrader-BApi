using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos;
using MatchTraderBApi.Models.Dtos.Trading;

namespace MatchTraderBApi.Models.Responses.Trading.TradingData;

public class MTrRetrieveClosedPositionsByLoginsOrGroupsResponse
{
    [JsonPropertyName("closedPositions")]
    public List<MTrClosedPosition> ClosedPositions { get; set; }
}