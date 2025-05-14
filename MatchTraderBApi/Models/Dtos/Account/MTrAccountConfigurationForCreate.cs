using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Account;

public class MTrAccountConfigurationForCreate
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
    public bool IsAccountTypeContact { get; set; }

    public MTrAccountConfigurationForCreate()
    {
        
    }
    
    public MTrAccountConfigurationForCreate(long? partnerId, string branchUuid, string roleUuid, string accountManagerUuid, string ibParentTradingAccountUuid, MTrCrmUserScope mTrCrmUserScope, bool isAccountTypeContact)
    {
        PartnerId = partnerId;
        BranchUuid = branchUuid;
        RoleUuid = roleUuid;
        AccountManagerUuid = accountManagerUuid;
        IbParentTradingAccountUuid = ibParentTradingAccountUuid;
        MTrCrmUserScope = mTrCrmUserScope;
        IsAccountTypeContact = isAccountTypeContact;
    }
}