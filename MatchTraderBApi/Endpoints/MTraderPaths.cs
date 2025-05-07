using System.Globalization;
using MatchTraderBApi.Enums;
using MatchTraderBApi.Enums.SortingFields;
using MatchTraderBApi.Extensions;

namespace MatchTraderBApi.Endpoints;

public static class MTraderPaths
{
    // General
    public static string ServiceInfo() => "/service-info";
    
    public static string GetBranches(DateTime? from, DateTime? to, BasicSortingField? sortField, SortingOrder? sortOrder) => "/v1/branches" +
        $"?from={from.ToString()}" +
        $"&to={to.ToString()}" +
        $"&sort={string.Join(',', sortField?.ToEnumString(), sortOrder?.ToEnumString())}";
    
    public static string GetOffers(DateTime? from, DateTime? to, BasicSortingField? sortField, SortingOrder? sortOrder) => "/v1/offers" +
        $"?from={from.ToString()}" +
        $"&to={to.ToString()}" +
        $"&sort={string.Join(',', sortField?.ToEnumString(), sortOrder?.ToEnumString())}";
    
    public static string GetRoles(DateTime? from, DateTime? to, BasicSortingField? sortField, SortingOrder? sortOrder) => "/v1/roles" +
        $"?from={from.ToString()}" +
        $"&to={to.ToString()}" +
        $"&sort={string.Join(',', sortField?.ToEnumString(), sortOrder?.ToEnumString())}";
    
    public static string RetrievePlatformLogsV2(int? page, int? size, DateTime? from, DateTime? to, SortingOrder? sortOrder) => "/v2/platform-logs" +
        $"?page={page.ToString()}" +
        $"&size={size.ToString()}" +
        $"&from={from.ToString()}" +
        $"&to={to.ToString()}" +
        $"&sort={sortOrder?.ToEnumString()}";

    // Accounts
    public static string GetAccounts(
        string? query, int? page, int? size, DateTime? from, DateTime? to, AccountType? accountType, AccountSortingField? sortField, SortingOrder? sortingOrder)
        => "/v1/accounts" +
           $"?query={query}" +
           $"&page={page.ToString()}" +
           $"&size={size.ToString()}" +
           $"&from={from.ToString()}" +
           $"&to={to.ToString()}" +
           $"&accountType={accountType?.ToEnumString()}" +
           $"&sort={string.Join(',', sortField?.ToEnumString(), sortingOrder?.ToEnumString())}";
    
    public static string GetAccountByEmail(string email) => $"/v1/accounts/by-email/{email}";
    public static string GetAccountByUuid(string accountUuid) => $"/v1/accounts/by-uuid/{accountUuid}";
    
    public static string GetAccountTimelineEvents(string accountUuid, AccountTimelineEventType? eventType, DateTime? from, DateTime? to, BasicSortingField? sortField, SortingOrder? sortOrder)
        => $"/v1/accounts/{accountUuid}/timeline-events" +
           $"?eventType={eventType?.ToEnumString()}" +
           $"&from={from.ToString()}" +
           $"&to={to.ToString()}" +
           $"&sort={string.Join(',', sortField?.ToEnumString(), sortOrder?.ToEnumString())}";
    
    public static string CreateAccount() => "/v1/accounts";
    public static string UpdateAccountInfo(string accountUuid) => $"/v1/accounts/{accountUuid}";
    public static string ChangeAccountPassword() => "/v1/change-password";
    public static string AddNote() => "/v1/note";
    public static string AddTask() => "/v1/task";

    // Trading Accounts
    public static string GetTradingAccounts(
        string? query, int? page, int? size, DateTime? from, DateTime? to, TradingAccountSortingField? sortField, SortingOrder? sortOrder) 
        => "/v1/trading-accounts" +
           $"?query={query}" +
           $"&page={page.ToString()}" +
           $"&size={size.ToString()}" +
           $"&from={from.ToString()}" +
           $"&to={to.ToString()}" +
           $"&sort={string.Join(',', sortField?.ToEnumString(), sortOrder?.ToEnumString())}";
    
    public static string GetTradingAccountByLogin(string systemUuid, string login) => $"/v1/trading-account?systemUuid={systemUuid}&login={login}";
    public static string CreateNewTradingAccount(string accountUuid) => $"/v1/accounts/{accountUuid}/trading-accounts";
    public static string UpdateTradingAccount(string systemUuid, string login) => $"/v1/trading-account?systemUuid={systemUuid}&login={login}";
    public static string ChangeLeverage(string systemUuid, string login) => $"/v1/trading-account/leverage?systemUuid={systemUuid}&login={login}";

    // Trading
    public static string GetSymbols(string systemUuid, string group, string[]? symbols)
        => symbols is null
            ? $"/v1/symbols?systemUuid={systemUuid}&group={group}"
            : $"/v1/symbols?systemUuid={systemUuid}&group={group}&symbols={string.Join(',', symbols)}"; 

    public static string OpenPosition() => "/v1/trading-accounts/positions/open";
    public static string CreatePendingOrder() => "/v1/trading-accounts/pending-order/create";
    public static string CancelPendingOrder() => "/v1/trading-accounts/pending-order/cancel";
    public static string CreateCorrectionOrder() => "/v1/trading-accounts/correction-order/create";
    public static string EditPosition() => "/v1/trading-accounts/positions/edit";
    public static string ClosePosition() => "/v1/trading-accounts/positions/close";
    public static string ClosePartialPosition() => "/v1/trading-accounts/positions/close-partially";
    public static string CloseAllPosition() => "/v1/trading-accounts/positions/close-all";

    // Trading Data
    public static string GetOpenPositions(string systemUuid, string login) 
        => $"/v1/trading-accounts/trading-data/open-positions?systemUuid={systemUuid}&login={login}";
    
    public static string GetClosedPositions(string systemUuid, string login, DateTime? from, DateTime? to) 
        => $"/v1/trading-accounts/trading-data/closed-positions?systemUuid={systemUuid}&login={login}" +
           $"&from={from.ToString()}" +
           $"&to={to.ToString()}";
    
    public static string GetActiveOrders(string systemUuid, string login) => $"/v1/trading-accounts/trading-data/active-orders?systemUuid={systemUuid}&login={login}";
    public static string GetLedgers(string systemUuid, string login, LedgerType[] types, DateTime? from, DateTime? to, int? limit)
        => $"/v1/trading-accounts/trading-data/ledgers" +
           $"?systemUuid={systemUuid}" +
           $"&login={login}" +
           $"&types[]={string.Join(',', types.Select(x => x.ToEnumString()))}" +
           $"&from={from.ToString()}" +
           $"&to={to.ToString()}" +
           $"&limit={limit.ToString()}";
    
    public static string GetGroups(string systemUuid) => $"/v1/groups?systemUuid={systemUuid}";
    public static string GetGroupNames(string systemUuid) => $"/v1/group-names?systemUuid={systemUuid}";
    public static string RetrieveOrdersHistoryByLoginsOrGroups() => "/v1/trading-accounts/trading-data/order-history";
    public static string RetrieveLedgersByLoginsOrGroups() => "/v1/trading-accounts/trading-data/ledgers";
    public static string RetrieveOpenPositionsByLoginsOrGroups() => "/v1/trading-accounts/open-positions";
    public static string RetrieveClosedPositionsByLoginsOrGroups() => "/v1/trading-accounts/closed-positions";
    public static string RetrieveOrdersHistoryByIds() => "/v1/trading-accounts/trading-data/order-history-by-ids";
    public static string RetrieveOpenPositionsByIds() => "/v1/trading-accounts/trading-data/open-positions-by-ids";
    public static string RetrieveClosedPositionsByIds() => "/v1/trading-accounts/trading-data/closed-positions-by-ids";
    public static string RetrieveActiveOrdersByIds() => "/v1/trading-accounts/trading-data/active-orders-by-ids";
    
    // Candles
    public static string GetCandles(string systemUuid, string symbol, CandleInterval interval, DateTime from, DateTime to)
        => $"/v1/candles" +
           $"?systemUuid={systemUuid}" +
           $"&symbol={symbol}" +
           $"&interval={interval.ToEnumString()}" +
           $"&from={from.ToString(CultureInfo.InvariantCulture)}" +
           $"&to={to.ToString(CultureInfo.InvariantCulture)}";
}
