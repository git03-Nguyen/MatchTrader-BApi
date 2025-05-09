using System.Text.Json.Serialization;
using MatchTraderBApi.Enums.Account;
using MatchTraderBApi.Models.Dtos.Account;

namespace MatchTraderBApi.Models.Responses.Account;

public class MTrCreateAccountResponse
{
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; }

    [JsonPropertyName("created")]
    public DateTime Created { get; set; }

    [JsonPropertyName("updated")]
    public DateTime Updated { get; set; }
    
    [JsonPropertyName("oneTimeToken")]
    public string OneTimeToken { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("verificationStatus")]
    public MTrVerificationStatus VerificationStatus { get; set; }

    [JsonPropertyName("type")]
    public MTrClientType ClientType { get; set; }

    [JsonPropertyName("personalDetails")]
    public MTrUserPersonalDetail PersonalDetails { get; set; }

    [JsonPropertyName("contactDetails")]
    public MTrUserContact ContactDetails { get; set; }

    [JsonPropertyName("accountConfiguration")]
    public MTrAccountConfiguration AccountConfiguration { get; set; }

    [JsonPropertyName("addressDetails")]
    public MTrUserAddress AddressDetails { get; set; }

    [JsonPropertyName("bankingDetails")]
    public MTrUserBankingDetail BankingDetails { get; set; }

    [JsonPropertyName("leadDetails")]
    public MTrUserLeadDetail LeadDetails { get; set; }
}


