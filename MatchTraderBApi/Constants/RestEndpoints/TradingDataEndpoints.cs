using System.Globalization;
using MatchTraderBApi.Enums;
using MatchTraderBApi.Extensions;

namespace MatchTraderBApi.Constants.RestEndpoints;

internal static class TradingDataEndpoints
{
    internal static string GetOpenPositions(string systemUuid, string login)
        => $"/v1/trading-accounts/trading-data/open-positions?systemUuid={systemUuid}&login={login}";

    internal static string GetClosedPositions(string systemUuid, string login, DateTime? from, DateTime? to)
        => $"/v1/trading-accounts/trading-data/closed-positions?systemUuid={systemUuid}&login={login}" +
           $"&from={from.ToString()}" +
           $"&to={to.ToString()}";

    internal static string GetActiveOrders(string systemUuid, string login) => $"/v1/trading-accounts/trading-data/active-orders?systemUuid={systemUuid}&login={login}";
    internal static string GetLedgers(string systemUuid, string login, IEnumerable<MTrLedgerType> types, DateTime? from, DateTime? to, int? limit)
        => $"/v1/trading-accounts/trading-data/ledgers" +
           $"?systemUuid={systemUuid}" +
           $"&login={login}" +
           $"&types[]={string.Join(',', types.Select(x => x.ToEnumString()))}" +
           $"&from={from.ToString()}" +
           $"&to={to.ToString()}" +
           $"&limit={limit.ToString()}";

    internal static string GetGroups(string systemUuid) => $"/v1/groups?systemUuid={systemUuid}";
    internal static string GetGroupNames(string systemUuid) => $"/v1/group-names?systemUuid={systemUuid}";
    internal static string RetrieveOrdersHistoryByLoginsOrGroups() => "/v1/trading-accounts/trading-data/order-history";
    internal static string RetrieveLedgersByLoginsOrGroups() => "/v1/trading-accounts/trading-data/ledgers";
    internal static string RetrieveOpenPositionsByLoginsOrGroups() => "/v1/trading-accounts/open-positions";
    internal static string RetrieveClosedPositionsByLoginsOrGroups() => "/v1/trading-accounts/closed-positions";
    internal static string RetrieveOrdersHistoryByIds() => "/v1/trading-accounts/trading-data/order-history-by-ids";
    internal static string RetrieveOpenPositionsByIds() => "/v1/trading-accounts/trading-data/open-positions-by-ids";
    internal static string RetrieveClosedPositionsByIds() => "/v1/trading-accounts/trading-data/closed-positions-by-ids";
    internal static string RetrieveActiveOrdersByIds() => "/v1/trading-accounts/trading-data/active-orders-by-ids";

    internal static string GetCandles(string systemUuid, string symbol, MTrCandleInterval interval, DateTime from, DateTime to)
        => $"/v1/candles" +
           $"?systemUuid={systemUuid}" +
           $"&symbol={symbol}" +
           $"&interval={interval.ToEnumString()}" +
           $"&from={from.ToString(CultureInfo.InvariantCulture)}" +
           $"&to={to.ToString(CultureInfo.InvariantCulture)}";
}