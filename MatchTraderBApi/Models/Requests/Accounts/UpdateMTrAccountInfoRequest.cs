using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos;

namespace MatchTraderBApi.Models.Requests.Accounts;

public class UpdateMTrAccountInfoRequest
{
    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("verificationStatus")]
    public string VerificationStatus { get; set; }

    [JsonPropertyName("clientType")]
    public string ClientType { get; set; }

    [JsonPropertyName("personalDetails")]
    public MTrUserPersonalDetail PersonalDetails { get; set; }

    [JsonPropertyName("contactDetails")]
    public MTrUserContact ContactDetails { get; set; }

    [JsonPropertyName("accountConfiguration")]
    public UpdateMTrAccountConfigurationData AccountConfiguration { get; set; }

    [JsonPropertyName("addressDetails")]
    public MTrUserAddress AddressDetails { get; set; }

    [JsonPropertyName("bankingDetails")]
    public MTrUserBankingDetail BankingDetails { get; set; }

    [JsonPropertyName("leadDetails")]
    public UpdateMTrUserLeadDetailData LeadDetails { get; set; }
}

public class UpdateMTrAccountConfigurationData
{
    [JsonPropertyName("branchUuid")]
    public string BranchUuid { get; set; }

    [JsonPropertyName("roleUuid")]
    public string RoleUuid { get; set; }

    [JsonPropertyName("accountManagerUuid")]
    public string AccountManagerUuid { get; set; }

    [JsonPropertyName("ibParentTradingAccountUuid")]
    public string IbParentTradingAccountUuid { get; set; }

    [JsonPropertyName("accountTypeContact")]
    public bool AccountTypeContact { get; set; }
}

public class UpdateMTrUserLeadDetailData
{
    [JsonPropertyName("leadStatusUuid")]
    public string LeadStatusUuid { get; set; }
}
