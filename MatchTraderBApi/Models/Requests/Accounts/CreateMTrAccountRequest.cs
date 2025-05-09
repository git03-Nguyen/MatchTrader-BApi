using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos;

namespace MatchTraderBApi.Models.Requests.Accounts;

public class CreateMTrAccountRequest
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
    public CreateMTrAccountConfigurationData? AccountConfiguration { get; set; }
    
    [JsonPropertyName("addressDetails")]
    public MTrUserAddress? AddressDetails { get; set; }
    
    [JsonPropertyName("bankingDetails")]
    public MTrUserBankingDetail? BankingDetails { get; set; }
    
    [JsonPropertyName("leadDetails")]
    public MTrUserLeadDetail? LeadDetails { get; set; }
}

public class CreateMTrAccountConfigurationData
{
    [JsonPropertyName("partnerId")]
    public long? PartnerId { get; set; }

    [JsonPropertyName("branchUuid")]
    public string BranchUuid { get; set; }

    [JsonPropertyName("roleUuid")]
    public string RoleUuid { get; set; }

    [JsonPropertyName("accountManagerUuid")]
    public string  AccountManagerUuid { get; set; }

    [JsonPropertyName("ibParentTradingAccountUuid")]
    public string IbParentTradingAccountUuid { get; set; }

    [JsonPropertyName("crmUserScope")]
    public MTrCrmUserScope MTrCrmUserScope { get; set; }

    [JsonPropertyName("accountTypeContact")]
    public bool AccountTypeContact { get; set; }
}