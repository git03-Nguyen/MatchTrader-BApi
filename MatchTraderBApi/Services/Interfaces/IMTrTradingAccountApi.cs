using MatchTraderBApi.Enums;
using MatchTraderBApi.Enums.SortingFields;
using MatchTraderBApi.Models.Dtos.Account;
using MatchTraderBApi.Models.Requests.Accounts.TradingAcounts;
using MatchTraderBApi.Models.Responses;
using MatchTraderBApi.Models.Responses.Account.TradingAccount;

namespace MatchTraderBApi.Services.Interfaces;

public interface IMTrTradingAccountApi
{
    Task<MTrResponse<MTrGetTradingAccountsResponse>> GetTradingAccounts(string? query, int? page, int? size,
        DateTime? from, DateTime? to, MTrTradingAccountSortingField? sortField, MTrSortingOrder? sortOrder);
    Task<MTrResponse<MTrTradingAccount>> GetTradingAccountByLogin(string systemUuid, string login);
    Task<MTrResponse<MTrTradingAccount>> CreateNewTradingAccount(string accountUuid, MTrCreateTradingAccountRequest request);
    Task<MTrResponse<string>> UpdateTradingAccount(string systemUuid, string login, MTrUpdateTradingAccountRequest request);
    Task<MTrResponse<string>> ChangeLeverage(string systemUuid, string login, uint leverage);
}
