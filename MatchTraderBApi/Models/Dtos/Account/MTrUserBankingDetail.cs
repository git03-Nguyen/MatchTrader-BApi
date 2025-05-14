using System.Text.Json.Serialization;

namespace MatchTraderBApi.Models.Dtos.Account;

public class MTrUserBankingDetail
{
    [JsonPropertyName("bankAddress")]
    public string? BankAddress { get; set; }

    [JsonPropertyName("bankSwiftCode")]
    public string? BankSwiftCode { get; set; }

    [JsonPropertyName("bankAccount")]
    public string? BankAccount { get; set; }

    [JsonPropertyName("bankName")]
    public string? BankName { get; set; }

    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }
    
    public MTrUserBankingDetail(string? bankAddress, string? bankSwiftCode, string? bankAccount, string? bankName, string? accountName)
    {
        BankAddress = bankAddress;
        BankSwiftCode = bankSwiftCode;
        BankAccount = bankAccount;
        BankName = bankName;
        AccountName = accountName;
    }
}
