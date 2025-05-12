using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Account;

public class MTrAccountManager
{
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}