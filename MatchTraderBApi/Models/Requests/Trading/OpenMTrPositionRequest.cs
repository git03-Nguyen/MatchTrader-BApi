using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Trading;

public class OpenMTrPositionRequest
{
    [JsonPropertyName("systemUuid")]
    public string SystemUuid { get; set; }

    [JsonPropertyName("login")]
    public string Login { get; set; }

    [JsonPropertyName("instrument")]
    public string Instrument { get; set; } // symbol name

    [JsonPropertyName("orderSide")]
    public string OrderSide { get; set; }

    [JsonPropertyName("volume")]
    public decimal Volume { get; set; }

    [JsonPropertyName("slPrice")]
    public decimal? SLPrice { get; set; }

    [JsonPropertyName("tpPrice")]
    public decimal? TPPrice { get; set; }
}