using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos;

public class MTrAccountConfiguration
{
    [JsonPropertyName("partnerId")]
    public long? PartnerId { get; set; }

    [JsonPropertyName("branchUuid")]
    public string BranchUuid { get; set; }

    [JsonPropertyName("roleUuid")]
    public string RoleUuid { get; set; }

    [JsonPropertyName("accountManager")]
    public MTrAccountManager MtrAccountManager { get; set; }

    [JsonPropertyName("ibParentTradingAccountUuid")]
    public string IbParentTradingAccountUuid { get; set; }

    [JsonPropertyName("crmUserScope")]
    public MTrCrmUserScope MTrCrmUserScope { get; set; }

    [JsonPropertyName("accountTypeContact")]
    public bool AccountTypeContact { get; set; }
}

public class MTrAccountManager
{
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public class MTrCrmUserScope
{
    [JsonPropertyName("branchScope")]
    public List<string> BranchScope { get; set; }

    [JsonPropertyName("managerPools")]
    public List<string> ManagerPools { get; set; }
}