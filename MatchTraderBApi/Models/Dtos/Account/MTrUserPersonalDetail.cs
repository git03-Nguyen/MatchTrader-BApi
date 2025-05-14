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

    public MTrUserPersonalDetail(string firstname, string lastname)
    {
        Firstname = firstname;
        Lastname = lastname;
    }

    public MTrUserPersonalDetail(string firstname, string lastname, DateTimeOffset? dateOfBirth = null, string? citizenship = null, string? language = null, string? maritalStatus = null, MTrUserPassport? passport = null, string? taxIdentificationNumber = null)
    {
        Firstname = firstname;
        Lastname = lastname;
        DateOfBirth = dateOfBirth?.UtcDateTime;
        Citizenship = citizenship;
        Language = language;
        MaritalStatus = maritalStatus;
        MTrUserPassport = passport;
        TaxIdentificationNumber = taxIdentificationNumber;
    }
}