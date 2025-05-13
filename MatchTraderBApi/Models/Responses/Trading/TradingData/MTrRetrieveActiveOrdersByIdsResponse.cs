using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos.Trading;

namespace MatchTraderBApi.Models.Responses.Trading.TradingData;

public class MTrRetrieveActiveOrdersByIdsResponse
{
    [JsonPropertyName("orders")]
    public List<MTrOrder> Orders { get; set; }
}