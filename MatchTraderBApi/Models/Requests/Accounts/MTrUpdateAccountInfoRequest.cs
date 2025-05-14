using System.Text.Json.Serialization;
using MatchTraderBApi.Enums.Account;
using MatchTraderBApi.Models.Dtos.Account;

namespace MatchTraderBApi.Models.Requests.Accounts;

public class MTrUpdateAccountInfoRequest
{
    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("verificationStatus")]
    public MTrVerificationStatus? VerificationStatus { get; set; }

    [JsonPropertyName("clientType")]
    public MTrClientType? ClientType { get; set; }

    [JsonPropertyName("personalDetails")]
    public MTrUserPersonalDetail? PersonalDetails { get; set; }

    [JsonPropertyName("contactDetails")]
    public MTrUserContact? ContactDetails { get; set; }

    [JsonPropertyName("accountConfiguration")]
    public MTrAccountConfigurationForUpdate? AccountConfiguration { get; set; }

    [JsonPropertyName("addressDetails")]
    public MTrUserAddress? AddressDetails { get; set; }

    [JsonPropertyName("bankingDetails")]
    public MTrUserBankingDetail? BankingDetails { get; set; }

    [JsonPropertyName("leadDetails")]
    public MTrUserLeadDetailForUpdate? LeadDetails { get; set; }
}