using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Responses.Trading;

public class OpenMTrPositionResponse
{
    /// <summary>
    /// Values: OK, REJECTED, PARTIAL_SUCCESS
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }
    
    [JsonPropertyName("orderId")]
    public string OrderId { get; set; }
}