using System.Text.Json.Serialization;
using MatchTraderBApi.Enums.Trading;

namespace MatchTraderBApi.Models.Dtos.Trading;

public class MTrOpenPosition
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }

    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

    [JsonPropertyName("volume")]
    public decimal Volume { get; set; }
    
    [JsonPropertyName("side")]
    public MTrOrderSide Side { get; set; }
    
    [JsonPropertyName("openTime")]
    public DateTime OpenTime { get; set; }
    
    [JsonPropertyName("openPrice")]
    public decimal OpenPrice { get; set; }

    [JsonPropertyName("stopLoss")]
    public decimal StopLoss { get; set; }

    [JsonPropertyName("takeProfit")]
    public decimal TakeProfit { get; set; }

    [JsonPropertyName("swap")]
    public decimal Swap { get; set; }

    [JsonPropertyName("profit")]
    public decimal Profit { get; set; }

    [JsonPropertyName("netProfit")]
    public decimal NetProfit { get; set; }

    [JsonPropertyName("currentPrice")]
    public decimal CurrentPrice { get; set; }

    [JsonPropertyName("commission")]
    public decimal Commission { get; set; }
    
    [JsonPropertyName("margin")]
    public decimal Margin { get; set; }
    
    [JsonPropertyName("positions")]
    public List<MTrPosition> Positions { get; set; }
}

public class MTrOpenPositionInner
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }

    [JsonPropertyName("volume")]
    public decimal Volume { get; set; }
    
    [JsonPropertyName("oldPartialVolume")]
    public decimal? OldPartialVolume { get; set; }
    
    [JsonPropertyName("side")]
    public MTrOrderSide Side { get; set; }
    
    [JsonPropertyName("openTime")]
    public DateTime OpenTime { get; set; }
    
    [JsonPropertyName("openPrice")]
    public decimal OpenPrice { get; set; }
    
    [JsonPropertyName("swap")]
    public decimal Swap { get; set; }
    
    [JsonPropertyName("profit")]
    public decimal Profit { get; set; }
    
    [JsonPropertyName("netProfit")]
    public decimal NetProfit { get; set; }
    
    [JsonPropertyName("currentPrice")]
    public decimal CurrentPrice { get; set; }
    
    [JsonPropertyName("commission")]
    public decimal Commission { get; set; }
}