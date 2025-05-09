using MatchTraderBApi.Enums;
using MatchTraderBApi.Enums.SortingFields;
using MatchTraderBApi.Extensions;

namespace MatchTraderBApi.Constants.RestEndpoints;

internal static class TradingAccountEndpoints
{
    internal static string GetTradingAccounts(
        string? query, int? page, int? size, DateTime? from, DateTime? to, MTrTradingAccountSortingField? sortField, MTrSortingOrder? sortOrder) 
        => "/v1/trading-accounts" +
           $"?query={query}" +
           $"&page={page.ToString()}" +
           $"&size={size.ToString()}" +
           $"&from={from.ToString()}" +
           $"&to={to.ToString()}" +
           $"&sort={string.Join(',', sortField?.ToEnumString(), sortOrder?.ToEnumString())}";
    
    internal static string GetTradingAccountByLogin(string systemUuid, string login) => $"/v1/trading-account?systemUuid={systemUuid}&login={login}";
    internal static string CreateNewTradingAccount(string accountUuid) => $"/v1/accounts/{accountUuid}/trading-accounts";
    internal static string UpdateTradingAccount(string systemUuid, string login) => $"/v1/trading-account?systemUuid={systemUuid}&login={login}";
    internal static string ChangeLeverage(string systemUuid, string login) => $"/v1/trading-account/leverage?systemUuid={systemUuid}&login={login}";
}