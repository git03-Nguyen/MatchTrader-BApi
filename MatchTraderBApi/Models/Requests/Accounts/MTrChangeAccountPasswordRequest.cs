using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Requests.Accounts;

public class MTrChangeAccountPasswordRequest
{
    [JsonPropertyName("accountUuid")]
    public string AccountUuid { get; set; }
    
    [JsonPropertyName("newPassword")]
    public string NewPassword { get; set; }
}
