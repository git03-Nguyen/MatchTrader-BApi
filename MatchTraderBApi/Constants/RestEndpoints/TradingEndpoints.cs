namespace MatchTraderBApi.Constants.RestEndpoints;

internal static class TradingEndpoints
{
    internal static string GetSymbols(string systemUuid, string group, string[]? symbols)
        => symbols is null
            ? $"/v1/symbols?systemUuid={systemUuid}&group={group}"
            : $"/v1/symbols?systemUuid={systemUuid}&group={group}&symbols={string.Join(',', symbols)}"; 

    internal static string OpenPosition() => "/v1/trading-accounts/positions/open";
    internal static string CreatePendingOrder() => "/v1/trading-accounts/pending-order/create";
    internal static string CancelPendingOrder() => "/v1/trading-accounts/pending-order/cancel";
    internal static string CreateCorrectionOrder() => "/v1/trading-accounts/correction-order/create";
    internal static string EditPosition() => "/v1/trading-accounts/positions/edit";
    internal static string ClosePosition() => "/v1/trading-accounts/positions/close";
    internal static string ClosePartialPosition() => "/v1/trading-accounts/positions/close-partially";
    internal static string CloseAllPosition() => "/v1/trading-accounts/positions/close-all";
}