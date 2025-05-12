using System.Text.Json.Serialization;
using MatchTraderBApi.Enums.Trading;

namespace MatchTraderBApi.Models.Responses.Trading;

public class MTrCreateCorrectionOrderResponse
{
    [JsonPropertyName("status")]
    public MTrTradingExecutionStatus Status { get; set; }
    
    [JsonPropertyName("orderId")]
    public string OrderId { get; set; }
}