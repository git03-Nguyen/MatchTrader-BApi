using System.Text.Json.Serialization;
using MatchTraderBApi.Enums.Account;
using MatchTraderBApi.Enums.Trading;

namespace MatchTraderBApi.Models.Requests.Trading;

public class MTrCreatePendingOrderRequest
{
    [JsonPropertyName("systemUuid")]
    public string SystemUuid { get; set; }

    [JsonPropertyName("login")]
    public string Login { get; set; }

    [JsonPropertyName("instrument")]
    public string Symbol { get; set; } 

    [JsonPropertyName("orderSide")]
    public MTrOrderSide Side { get; set; }

    [JsonPropertyName("volume")]
    public decimal Volume { get; set; }

    [JsonPropertyName("slPrice")]
    public decimal? SLPrice { get; set; }

    [JsonPropertyName("tpPrice")]
    public decimal? TPPrice { get; set; }

    [JsonPropertyName("activationPrice")]
    public decimal? ActivationPrice { get; set; }

    [JsonPropertyName("type")]
    public MTrOrderType Type { get; set; }
}