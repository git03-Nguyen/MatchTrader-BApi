using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Trading;

public class MTrCreatePendingOrderRequest
{
    [JsonPropertyName("systemUuid")]
    public string SystemUuid { get; set; }

    [JsonPropertyName("login")]
    public string Login { get; set; }

    /// <summary>
    /// Symbol name
    /// </summary>
    [JsonPropertyName("instrument")]
    public string Instrument { get; set; } 

    /// <summary>
    /// Values: BUY, SELL
    /// </summary>
    [JsonPropertyName("orderSide")]
    public string OrderSide { get; set; }

    [JsonPropertyName("volume")]
    public decimal Volume { get; set; }

    [JsonPropertyName("slPrice")]
    public decimal? SLPrice { get; set; }

    [JsonPropertyName("tpPrice")]
    public decimal? TPPrice { get; set; }

    [JsonPropertyName("activationPrice")]
    public decimal? ActivationPrice { get; set; }

    /// <summary>
    /// Values: LIMIT, STOP
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}