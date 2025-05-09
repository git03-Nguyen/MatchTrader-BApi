using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos;

public class MTrGroupConfiguration
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    [JsonPropertyName("currencyPrecision")]
    public int CurrencyPrecision { get; set; }

    [JsonPropertyName("groupOwner")]
    public string GroupOwner { get; set; }

    [JsonPropertyName("symbols")]
    public Dictionary<string, MTrSymbolConfiguration> Symbols { get; set; }
}