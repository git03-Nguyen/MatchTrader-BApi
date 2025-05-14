using System.Text.Json.Serialization;
using MatchTraderBApi.Enums.Account;
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
    public MTrClientType? ClientType { get; set; }
    
    [JsonPropertyName("createAsDepositedAccount")]
    public bool IsCreateAsDepositedAccount { get; set; }
    
    [JsonPropertyName("personalDetails")]
    public MTrUserPersonalDetail PersonalDetails { get; set; }
    
    [JsonPropertyName("contactDetails")]
    public MTrUserContact? ContactDetails { get; set; }
    
    [JsonPropertyName("accountConfiguration")]
    public MTrAccountConfigurationForCreate? AccountConfiguration { get; set; }
    
    [JsonPropertyName("addressDetails")]
    public MTrUserAddress? AddressDetails { get; set; }
    
    [JsonPropertyName("bankingDetails")]
    public MTrUserBankingDetail? BankingDetails { get; set; }
    
    [JsonPropertyName("leadDetails")]
    public MTrUserLeadDetail? LeadDetails { get; set; }

    public MTrCreateAccountRequest(string email, string password, MTrUserPersonalDetail personalDetails)
    {
        Email = email;
        Password = password;
        PersonalDetails = personalDetails;
    }

    public MTrCreateAccountRequest(string email, string password, string? offerUuid, MTrClientType? clientType, bool isCreateAsDepositedAccount, MTrUserPersonalDetail personalDetails, MTrUserContact? contactDetails, MTrAccountConfigurationForCreate? accountConfiguration, MTrUserAddress? addressDetails, MTrUserBankingDetail? bankingDetails, MTrUserLeadDetail? leadDetails)
    {
        Email = email;
        Password = password;
        OfferUuid = offerUuid;
        ClientType = clientType;
        IsCreateAsDepositedAccount = isCreateAsDepositedAccount;
        PersonalDetails = personalDetails;
        ContactDetails = contactDetails;
        AccountConfiguration = accountConfiguration;
        AddressDetails = addressDetails;
        BankingDetails = bankingDetails;
        LeadDetails = leadDetails;
    }
}