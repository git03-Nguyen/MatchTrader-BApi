using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Account;

public class MTrUserPersonalDetail
{
    [JsonPropertyName("firstname")]
    public string Firstname { get; set; }

    [JsonPropertyName("lastname")]
    public string Lastname { get; set; }

    [JsonPropertyName("dateOfBirth")]
    public DateTime? DateOfBirth { get; set; }

    [JsonPropertyName("citizenship")]
    public string? Citizenship { get; set; }

    [JsonPropertyName("language")]
    public string? Language { get; set; }

    [JsonPropertyName("maritalStatus")]
    public string? MaritalStatus { get; set; }

    [JsonPropertyName("passport")]
    public MTrUserPassport? MTrUserPassport { get; set; }

    [JsonPropertyName("taxIdentificationNumber")]
    public string? TaxIdentificationNumber { get; set; }
}