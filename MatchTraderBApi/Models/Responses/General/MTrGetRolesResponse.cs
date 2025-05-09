using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos;
using MatchTraderBApi.Models.Dtos.General;

namespace MatchTraderBApi.Models.Responses.General;

public class MTrGetRolesResponse
{
    [JsonPropertyName("roles")]
    public List<MTrRole> Roles { get; set; }
}