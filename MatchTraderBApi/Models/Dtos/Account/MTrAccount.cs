using System.Text.Json.Serialization;
using MatchTraderBApi.Enums.Account;

namespace MatchTraderBApi.Models.Dtos.Account;

public class MTrAccount
{
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; }

    [JsonPropertyName("created")]
    public DateTime? Created { get; set; }

    [JsonPropertyName("updated")]
    public DateTime? Updated { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("verificationStatus")]
    public MTrVerificationStatus VerificationStatus { get; set; }

    [JsonPropertyName("type")]
    public MTrClientType? ClientType { get; set; }

    [JsonPropertyName("personalDetails")]
    public MTrUserPersonalDetail MTrUserPersonalDetail { get; set; }

    [JsonPropertyName("contactDetails")]
    public MTrUserContact MTrUserContactDetail { get; set; }

    [JsonPropertyName("accountConfiguration")]
    public MTrAccountConfiguration MTrAccountConfiguration { get; set; }

    [JsonPropertyName("addressDetails")]
    public MTrUserAddress MTrUserAddressDetail { get; set; }

    [JsonPropertyName("bankingDetails")]
    public MTrUserBankingDetail MTrUserBankingDetail { get; set; }

    [JsonPropertyName("leadDetails")]
    public MTrUserLeadDetail MTrUserLeadDetail { get; set; }
}