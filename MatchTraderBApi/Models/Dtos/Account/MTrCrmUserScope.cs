using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Account;

public class MTrCrmUserScope
{
    [JsonPropertyName("branchScope")]
    public HashSet<string>? BranchScope { get; set; }

    [JsonPropertyName("managerPools")]
    public HashSet<string>? ManagerPools { get; set; }
}