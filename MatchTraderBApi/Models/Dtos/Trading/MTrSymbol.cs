using System.Text.Json.Serialization;
using MatchTraderBApi.Enums.Trading;

namespace MatchTraderBApi.Models.Dtos.Trading;

public class MTrSymbol
{
    [JsonPropertyName("isSessionOpen")]
    public bool IsSessionOpen { get; set; }

    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }

    [JsonPropertyName("alias")]
    public string Alias { get; set; }

    [JsonPropertyName("baseCurrency")]
    public string BaseCurrency { get; set; }

    [JsonPropertyName("quoteCurrency")]
    public string QuoteCurrency { get; set; }

    [JsonPropertyName("type")]
    public MTrSymbolType Type { get; set; }

    [JsonPropertyName("pricePrecision")]
    public int? PricePrecision { get; set; }

    [JsonPropertyName("volumePrecision")]
    public int? VolumePrecision { get; set; }

    [JsonPropertyName("swapBuy")]
    public decimal? SwapBuy { get; set; }

    [JsonPropertyName("swapSell")]
    public decimal? SwapSell { get; set; }

    [JsonPropertyName("swapType")]
    public string SwapType { get; set; }

    [JsonPropertyName("volumeMin")]
    public decimal? VolumeMin { get; set; }

    [JsonPropertyName("volumeStep")]
    public decimal? VolumeStep { get; set; }

    [JsonPropertyName("volumeMax")]
    public decimal? VolumeMax { get; set; }

    [JsonPropertyName("commissionMin")]
    public decimal? CommissionMin { get; set; }

    [JsonPropertyName("contractSize")]
    public decimal? ContractSize { get; set; }

    [JsonPropertyName("sizeOfOnePoint")]
    public decimal? SizeOfOnePoint { get; set; }

    [JsonPropertyName("multiplier")]
    public decimal? Multiplier { get; set; }

    [JsonPropertyName("divider")]
    public decimal? Divider { get; set; }

    [JsonPropertyName("leverage")]
    public decimal? Leverage { get; set; }

    [JsonPropertyName("bidMarkup")]
    public decimal? BidMarkup { get; set; }

    [JsonPropertyName("askMarkup")]
    public decimal? AskMarkup { get; set; }

    [JsonPropertyName("freezeLevel")]
    public int? FreezeLevel { get; set; }

    [JsonPropertyName("stopsLevel")]
    public int? StopsLevel { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("tags")]
    public List<string> Tags { get; set; }

    [JsonPropertyName("tradingHours")]
    public List<MTrTradingHour> TradingHours { get; set; }

    [JsonPropertyName("isFixedLeverage")]
    public bool IsFixedLeverage { get; set; }

    [JsonPropertyName("terminationType")]
    public string TerminationType { get; set; }

    [JsonPropertyName("terminationDate")]
    public string TerminationDate { get; set; }

    [JsonPropertyName("sessionOpen")]
    public bool SessionOpen { get; set; }
}