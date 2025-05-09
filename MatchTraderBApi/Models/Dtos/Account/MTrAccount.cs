using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Account;

public class MTrAccount
{
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; }

    [JsonPropertyName("created")]
    public string Created { get; set; }

    [JsonPropertyName("updated")]
    public string Updated { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("verificationStatus")]
    public string VerificationStatus { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

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