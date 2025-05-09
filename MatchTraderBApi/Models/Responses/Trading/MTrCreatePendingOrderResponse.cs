using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Responses.Trading;

public class MTrCreatePendingOrderResponse
{
    [JsonPropertyName("status")]
    public string Status { get; set; }
    
    [JsonPropertyName("orderId")]
    public string OrderId { get; set; }
}