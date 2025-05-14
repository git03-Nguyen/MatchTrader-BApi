using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Account;

public class MTrAccountConfigurationForUpdate
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
    public bool IsAccountTypeContact { get; set; }

    public MTrAccountConfigurationForUpdate()
    {
    }

    public MTrAccountConfigurationForUpdate(string branchUuid, string roleUuid, string accountManagerUuid, string ibParentTradingAccountUuid, bool isAccountTypeContact)
    {
        BranchUuid = branchUuid;
        RoleUuid = roleUuid;
        AccountManagerUuid = accountManagerUuid;
        IbParentTradingAccountUuid = ibParentTradingAccountUuid;
        IsAccountTypeContact = isAccountTypeContact;
    }
}