using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Account;

public class MTrUserContact
{
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }

    [JsonPropertyName("faxNumber")]
    public string? FaxNumber { get; set; }

    [JsonPropertyName("toContact")]
    public MTrToContact? ToContact { get; set; }
    
    public MTrUserContact(string? phoneNumber = null, string? faxNumber = null, MTrToContact? toContact = null)
    {
        PhoneNumber = phoneNumber;
        FaxNumber = faxNumber;
        ToContact = toContact;
    }
}