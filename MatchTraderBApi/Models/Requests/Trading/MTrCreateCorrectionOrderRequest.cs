using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Trading;

public class MTrCreateCorrectionOrderRequest
{
    [JsonPropertyName("systemUuid")]
    public string SystemUuid { get; set; }

    [JsonPropertyName("login")]
    public string Login { get; set; }

    [JsonPropertyName("instrument")]
    public string Instrument { get; set; }

    [JsonPropertyName("volume")]
    public decimal Volume { get; set; }

    /// <summary>
    /// Values: LIMIT, STOP
    /// </summary>
    [JsonPropertyName("side")]
    public string Side { get; set; }

    [JsonPropertyName("price")]
    public string Price { get; set; }

    [JsonPropertyName("closingOrderId")]
    public string ClosingOrderId { get; set; }

    [JsonPropertyName("comment")]
    public string Comment { get; set; }
}