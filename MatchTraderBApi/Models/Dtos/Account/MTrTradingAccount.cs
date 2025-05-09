using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Account;

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