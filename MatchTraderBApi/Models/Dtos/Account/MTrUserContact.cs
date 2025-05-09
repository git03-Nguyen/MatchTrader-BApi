using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Account;

public class MTrUserContact
{
    [JsonPropertyName("phoneNumber")]
    public string PhoneNumber { get; set; } = string.Empty;

    [JsonPropertyName("faxNumber")]
    public string FaxNumber { get; set; } = string.Empty;

    [JsonPropertyName("toContact")]
    public ToContact? ToContact { get; set; }
}

public class ToContact
{
    [JsonPropertyName("toContactDate")]
    public string ToContactDate { get; set; }  = string.Empty;

    [JsonPropertyName("alreadyContacted")]
    public bool AlreadyContacted { get; set; } = false;
}