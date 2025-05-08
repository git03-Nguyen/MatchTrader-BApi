using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Responses.Accounts.TradingAccounts;

public class CreateMTrTradingAccountResponse
{
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; }

    [JsonPropertyName("created")]
    public DateTime Created { get; set; }

    [JsonPropertyName("updated")]
    public DateTime Updated { get; set; }

    [JsonPropertyName("login")]
    public string Login { get; set; }

    [JsonPropertyName("offerUuid")]
    public string OfferUuid { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("commissionUuid")]
    public string CommissionUuid { get; set; }
}
