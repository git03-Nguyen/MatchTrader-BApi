using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos;

namespace MatchTraderBApi.Models.Responses.Accounts;

public class CreateMTrAccountResponse
{
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; }

    [JsonPropertyName("created")]
    public string Created { get; set; }

    [JsonPropertyName("updated")]
    public string Updated { get; set; }
    
    [JsonPropertyName("oneTimeToken")]
    public string OnTimeToken { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("verificationStatus")]
    public string VerificationStatus { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

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


