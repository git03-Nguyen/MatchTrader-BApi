using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos;

public class MTrTradingAccount
{
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; }

    [JsonPropertyName("login")]
    public string Login { get; set; }

    [JsonPropertyName("created")]
    public DateTime Created { get; set; }

    [JsonPropertyName("accountInfo")]
    public MTrAccountInfo MTrAccountInfo { get; set; }

    [JsonPropertyName("offerUuid")]
    public string OfferUuid { get; set; }

    [JsonPropertyName("systemUuid")]
    public string SystemUuid { get; set; }

    [JsonPropertyName("commissionUuid")]
    public string CommissionUuid { get; set; }

    [JsonPropertyName("group")]
    public string Group { get; set; }

    [JsonPropertyName("leverage")]
    public int Leverage { get; set; }

    [JsonPropertyName("access")]
    public string Access { get; set; }

    [JsonPropertyName("accountType")]
    public string AccountType { get; set; }

    [JsonPropertyName("financeInfo")]
    public MTrFinanceInfo MTrFinanceInfo { get; set; }
}

public class MTrAccountInfo
{
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }
}

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
