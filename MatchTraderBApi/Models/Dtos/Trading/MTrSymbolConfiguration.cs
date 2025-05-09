using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Trading;

public class MTrSymbolConfiguration
{
    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }

    [JsonPropertyName("bidMarkup")]
    public decimal? BidMarkup { get; set; }

    [JsonPropertyName("askMarkup")]
    public decimal? AskMarkup { get; set; }

    [JsonPropertyName("leverage")]
    public int? Leverage { get; set; }

    [JsonPropertyName("swapBuy")]
    public decimal? SwapBuy { get; set; }

    [JsonPropertyName("swapSell")]
    public decimal? SwapSell { get; set; }

    [JsonPropertyName("freezeLevel")]
    public int? FreezeLevel { get; set; }

    [JsonPropertyName("stopsLevel")]
    public int? StopsLevel { get; set; }

    [JsonPropertyName("swapType")]
    public string SwapType { get; set; }

    [JsonPropertyName("volumeMin")]
    public decimal? VolumeMin { get; set; }

    [JsonPropertyName("volumeMax")]
    public decimal? VolumeMax { get; set; }

    [JsonPropertyName("minCommission")]
    public decimal? MinCommission { get; set; }

    [JsonPropertyName("fixedLeverage")]
    public bool FixedLeverage { get; set; }

    [JsonPropertyName("rawLeverage")]
    public int? RawLeverage { get; set; }

    [JsonPropertyName("commissionType")]
    public string CommissionType { get; set; }

    [JsonPropertyName("commissionPerMillion")]
    public decimal? CommissionPerMillion { get; set; }
}