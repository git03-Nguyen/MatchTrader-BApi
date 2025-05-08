using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos;

public class MTrUserPersonalDetail
{
    [JsonPropertyName("firstname")]
    public string Firstname { get; set; }

    [JsonPropertyName("lastname")]
    public string Lastname { get; set; }

    [JsonPropertyName("dateOfBirth")]
    public string DateOfBirth { get; set; } = string.Empty;

    [JsonPropertyName("citizenship")]
    public string Citizenship { get; set; } = string.Empty;

    [JsonPropertyName("language")]
    public string Language { get; set; } = string.Empty;

    [JsonPropertyName("maritalStatus")]
    public string MaritalStatus { get; set; } = string.Empty;

    [JsonPropertyName("passport")]
    public MTrUserPassport? MTrUserPassport { get; set; }

    [JsonPropertyName("taxIdentificationNumber")]
    public string TaxIdentificationNumber { get; set; } = string.Empty;
}

public class MTrUserPassport
{
    [JsonPropertyName("number")]
    public string Number { get; set; } = string.Empty;

    [JsonPropertyName("country")]
    public string Country { get; set; } = string.Empty;
}