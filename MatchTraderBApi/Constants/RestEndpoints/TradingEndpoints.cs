namespace MatchTraderBApi.Constants.RestEndpoints;

public static class TradingEndpoints
{
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
}