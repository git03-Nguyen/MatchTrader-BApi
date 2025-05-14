using System.Text.Json.Serialization;
using MatchTraderBApi.Models.Dtos.Account;

namespace MatchTraderBApi.Models.Responses.Account;

public class MTrGetAccountsResponse
{
    [JsonPropertyName("content")]
    public List<MTrAccount> Content { get; set; } = new();

    [JsonPropertyName("totalPages")]
    public int? TotalPages { get; set; }

    [JsonPropertyName("totalElements")]
    public long? TotalElements { get; set; }

    [JsonPropertyName("number")]
    public int? Number { get; set; }

    [JsonPropertyName("size")]
    public int? Size { get; set; }
}