using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Trading;

public class CancelMTrPendingOrderRequest
{
    [JsonPropertyName("systemUuid")]
    public string SystemUuid { get; set; }

    [JsonPropertyName("login")]
    public string Login { get; set; }

    [JsonPropertyName("instrument")]
    public string Instrument { get; set; }

    [JsonPropertyName("orderId")]
    public string OrderId { get; set; }
}