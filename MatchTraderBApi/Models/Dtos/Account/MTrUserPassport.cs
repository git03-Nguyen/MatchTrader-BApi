using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Account;

public class MTrUserPassport
{
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }
    
    public MTrUserPassport(string? number = null, string? country = null)
    {
        Number = number;
        Country = country;
    }
}