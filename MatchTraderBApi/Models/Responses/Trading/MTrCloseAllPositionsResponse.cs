using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Responses.Trading;

public class MTrCloseAllPositionsResponse
{
    [JsonPropertyName("orderId")]
    public string OrderId { get; set; }
}