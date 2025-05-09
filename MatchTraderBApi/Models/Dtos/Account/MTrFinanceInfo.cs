using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Account;

public class MTrFinanceInfo
{
    [JsonPropertyName("balance")]
    public decimal? Balance { get; set; }

    [JsonPropertyName("equity")]
    public decimal? Equity { get; set; }

    [JsonPropertyName("profit")]
    public decimal? Profit { get; set; }

    [JsonPropertyName("netProfit")]
    public decimal? NetProfit { get; set; }

    [JsonPropertyName("margin")]
    public decimal? Margin { get; set; }

    [JsonPropertyName("freeMargin")]
    public decimal? FreeMargin { get; set; }

    [JsonPropertyName("marginLevel")]
    public decimal? MarginLevel { get; set; }

    [JsonPropertyName("credit")]
    public decimal? Credit { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    [JsonPropertyName("currencyPrecision")]
    public int CurrencyPrecision { get; set; }
}