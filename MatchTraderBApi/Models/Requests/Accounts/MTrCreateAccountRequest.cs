using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos;
using MatchTraderBApi.Models.Dtos.Account;

namespace MatchTraderBApi.Models.Requests.Accounts;

public class MTrCreateAccountRequest
{
    [JsonPropertyName("email")]
    public string Email { get; set; }
    
    [JsonPropertyName("password")]
    public string Password { get; set; }
    
    [JsonPropertyName("offerUuid")]
    public string? OfferUuid { get; set; }
    
    [JsonPropertyName("clientType")]
    public string? ClientType { get; set; }
    
    [JsonPropertyName("createAsDepositedAccount")]
    public bool CreateAsDepositedAccount { get; set; }
    
    [JsonPropertyName("personalDetails")]
    public MTrUserPersonalDetail PersonalDetails { get; set; }
    
    [JsonPropertyName("contactDetails")]
    public MTrUserContact? ContactDetails { get; set; }
    
    [JsonPropertyName("accountConfiguration")]
    public MTrCreateAccountConfigurationData? AccountConfiguration { get; set; }
    
    [JsonPropertyName("addressDetails")]
    public MTrUserAddress? AddressDetails { get; set; }
    
    [JsonPropertyName("bankingDetails")]
    public MTrUserBankingDetail? BankingDetails { get; set; }
    
    [JsonPropertyName("leadDetails")]
    public MTrUserLeadDetail? LeadDetails { get; set; }
}