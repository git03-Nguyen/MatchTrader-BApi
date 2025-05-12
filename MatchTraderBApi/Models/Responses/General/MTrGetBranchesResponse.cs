using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos.General;

namespace MatchTraderBApi.Models.Responses.General;

public class MTrGetBranchesResponse
{
    [JsonPropertyName("branches")] 
    public List<MTrBranch> Branches { get; set; } = [];
}