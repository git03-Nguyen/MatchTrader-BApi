using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Account;

public class MTrToContact
{
    [JsonPropertyName("toContactDate")]
    public DateTime ToContactDate { get; set; }

    [JsonPropertyName("alreadyContacted")]
    public bool AlreadyContacted { get; set; }
}