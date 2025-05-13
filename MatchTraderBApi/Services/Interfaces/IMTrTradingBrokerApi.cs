using MatchTraderBApi.Enums;
using MatchTraderBApi.Models.Dtos.Trading;
using MatchTraderBApi.Models.Requests.Trading.TradingData;
using MatchTraderBApi.Models.Responses;
using MatchTraderBApi.Models.Responses.Trading;
using MatchTraderBApi.Models.Responses.Trading.TradingData;
using MatchTraderBApi.Models.Responses.Trading.TradingData.Candle;

namespace MatchTraderBApi.Services.Interfaces;

public interface IMTrTradingBrokerApi
{
    Task<MTrResponse<MTrGetSymbolsResponse>> GetSymbols(string systemUuid, string group, string[]? symbols, CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrCloseAllPositionsResponse>> CloseAllPositions(string systemUuid, string[] logins, CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrGetOpenPositionsResponse>> GetOpenPositions(string systemUuid, string login, CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrGetClosedPositionsResponse>> GetClosedPositions(string systemUuid, string login, DateTime? from, DateTime? to, CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrGetActiveOrdersResponse>> GetActiveOrders(string systemUuid, string login, CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrGetLedgersResponse>> GetLedgers(string systemUuid, string login, MTrLedgerType[] types, DateTime? from, DateTime? to, int? limit, CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrGroupConfiguration>> GetGroup(string systemUuid, string name, CancellationToken cancellationToken = default);
    Task<MTrResponse<List<string>>> GetGroupNames(string systemUuid, CancellationToken cancellationToken = default);
    Task<MTrResponse<List<MTrRetrieveOrdersHistoryByLoginsOrGroupsResponse>>> RetrieveOrdersHistoryByLoginsOrGroups(MTrRetrieveOrdersHistoryByLoginsOrGroupsRequest request, CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrRetrieveLedgersByLoginsOrGroupsResponse>> RetrieveLedgersByLoginsOrGroups(MTrRetrieveLedgersByLoginsOrGroupsRequest request, CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrRetrieveOpenPositionsByLoginsOrGroupsResponse>> RetrieveOpenPositionsByLoginsOrGroups(MTrRetrieveOpenPositionsByLoginsOrGroupsRequest request, CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrRetrieveClosedPositionsByLoginsOrGroupsResponse>> RetrieveClosedPositionsByLoginsOrGroups(MTrRetrieveClosedPositionsByLoginsOrGroupsRequest request, CancellationToken cancellationToken = default);
    Task<MTrResponse<List<MTrOrderHistory>>> RetrieveOrdersHistoryByIds(MTrRetrieveOrdersHistoryByIdsRequest request, CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrRetrieveOpenPositionsByIdsResponse>> RetrieveOpenPositionsByIds(MTrRetrieveOpenPositionsByIdsRequest request, CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrRetrieveClosedPositionsByLoginsOrGroupsResponse>> RetrieveClosedPositionsByIds(MTrRetrieveClosedPositionsByIdsRequest request, CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrRetrieveActiveOrdersByIdsResponse>> RetrieveActiveOrdersByIds(MTrRetrieveActiveOrdersByIdsRequest request, CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrGetCandlesResponse>> GetCandles(string systemUuid, string symbol, MTrCandleInterval interval, DateTime from, DateTime to, CancellationToken cancellationToken = default);
}