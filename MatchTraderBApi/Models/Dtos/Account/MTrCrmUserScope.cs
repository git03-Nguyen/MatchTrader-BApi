using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Account;

public class MTrCrmUserScope
{
    [JsonPropertyName("branchScope")]
    public List<string> BranchScope { get; set; }

    [JsonPropertyName("managerPools")]
    public List<string> ManagerPools { get; set; }
}