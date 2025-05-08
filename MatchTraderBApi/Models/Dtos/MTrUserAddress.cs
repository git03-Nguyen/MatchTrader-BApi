using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos;

public class MTrUserAddress
{
    [JsonPropertyName("country")]
    public string Country { get; set; }

    [JsonPropertyName("state")]
    public string State { get; set; }

    [JsonPropertyName("city")]
    public string City { get; set; }

    [JsonPropertyName("postCode")]
    public string PostCode { get; set; }

    [JsonPropertyName("address")]
    public string Address { get; set; }
}
