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
        DateTime? from, DateTime? to, MTrTradingAccountSortingField? sortField, MTrSortingOrder? sortOrder, CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrTradingAccount>> GetTradingAccountByLogin(string systemUuid, string login, CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrTradingAccount>> CreateNewTradingAccount(string accountUuid, MTrCreateTradingAccountRequest request, CancellationToken cancellationToken = default);
    Task<MTrResponse<object?>> UpdateTradingAccount(string systemUuid, string login, MTrUpdateTradingAccountRequest request, CancellationToken cancellationToken = default);
    Task<MTrResponse<object?>> ChangeLeverage(string systemUuid, string login, uint leverage, CancellationToken cancellationToken = default);
}
