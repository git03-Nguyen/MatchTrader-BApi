using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos;

namespace MatchTraderBApi.Models.Responses.Trading.TradingData;

public class GetMTrClosedPositionsResponse
{
    [JsonPropertyName("closedPositions")]
    public List<MTrClosePosition> ClosedPositions { get; set; }
}