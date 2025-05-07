namespace MatchTraderBApi.Endpoints;

public static class MTraderPaths
{
    // General
    public static string ServiceInfo() => "/service-info";
    public static string GetBranches() => "/v1/branches";
    public static string GetOffers() => "/v1/offers";
    public static string GetRoles() => "/v1/roles";

    // Accounts
    public static string GetAccounts() => "/v1/accounts";
    public static string GetAccountByEmail(string email) => $"/v1/accounts/by-email/{email}";
    public static string GetAccountByUuid(string accountUuid) => $"/v1/accounts/by-uuid/{accountUuid}";
    public static string GetAccountTimelineEvents(string accountUuid) => $"/v1/accounts/{accountUuid}/timeline-events";
    public static string CreateAccount() => "/v1/accounts";
    public static string UpdateAccountInfo(string accountUuid) => $"/v1/accounts/{accountUuid}";
    public static string ChangeAccountPassword() => "/v1/change-password";
    public static string AddNote() => "/v1/note";
    public static string AddTask() => "/v1/task";

    // Trading Accounts
    public static string GetTradingAccounts() => "/v1/trading-accounts";
    public static string GetTradingAccountByLogin(string systemUuid, string login) => $"/v1/trading-account?systemUuid={systemUuid}&login={login}";
    public static string CreateNewTradingAccount(string accountUuid) => $"/v1/accounts/{accountUuid}/trading-accounts";
    public static string UpdateTradingAccount(string systemUuid, string login) => $"/v1/trading-account?systemUuid={systemUuid}&login={login}";
    public static string ChangeLeverage(string systemUuid, string login) => $"/v1/trading-account/leverage?systemUuid={systemUuid}&login={login}";

    // Trading
    public static string GetSymbols(string systemUuid, string group, string[]? symbols) => $"/v1/symbols?systemUuid={systemUuid}&group={group}&symbols={string.Join(',', symbols)}";
    public static string OpenPosition() => "/v1/trading-accounts/positions/open";
    public static string CreatePendingOrder() => "/v1/trading-accounts/pending-order/create";
    public static string CancelPendingOrder() => "/v1/trading-accounts/pending-order/cancel";
    public static string CreateCorrectionOrder() => "/v1/trading-accounts/correction-order/create";
    public static string EditPosition() => "/v1/trading-accounts/positions/edit";
    public static string ClosePosition() => "/v1/trading-accounts/positions/close";
    public static string ClosePartialPosition() => "/v1/trading-accounts/positions/close-partially";
    public static string CloseAllPosition() => "/v1/trading-accounts/positions/close-all";

    // Trading Data
    public static string GetOpenPositions(string systemUuid, string login) => $"/v1/trading-accounts/trading-data/open-positions?systemUuid={systemUuid}&login={login}";
    public static string GetClosedPositions(string systemUuid, string login) => $"/v1/trading-accounts/trading-data/closed-positions?systemUuid={systemUuid}&login={login}";
    public static string GetActiveOrders(string systemUuid, string login) => $"/v1/trading-accounts/trading-data/active-orders?systemUuid={systemUuid}&login={login}";
    public static string GetLedgers(string systemUuid, string login, LedgerType[] types, DateTime? from, DateTime? to, int? limit)
        => $"/v1/trading-accounts/trading-data/ledgers" +
           $"?systemUuid={systemUuid}" +
           $"&login={login}" +
           $"&types[]={string.Join(',', types.Select(x => x.ToString()))}" +
           $"&from={from.ToString()}" +
           $"&to={to.ToString()}" +
           $"&limit={limit.ToString()}";
    
    
}

public enum LedgerType
{
    DEPOSIT,
    WITHDRAWAL,
    CREDIT_IN,
    CREDIT_OUT,
    AGENT_COMMISSION,
    COMMISSIONS,
    SWAPS,
    CLOSED_POSITION
}