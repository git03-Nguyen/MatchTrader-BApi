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
    Task<MTrResponse<MTrGetSymbolsResponse>> GetSymbols(string systemUuid, string group, string[]? symbols);
    Task<MTrResponse<MTrCloseAllPositionsResponse>> CloseAllPositions(string systemUuid, string[] logins);
    Task<MTrResponse<MTrGetOpenPositionsResponse>> GetOpenPositions(string systemUuid, string login);
    Task<MTrResponse<MTrGetClosedPositionsResponse>> GetClosedPositions(string systemUuid, string login, DateTime? from, DateTime? to);
    Task<MTrResponse<MTrGetActiveOrdersResponse>> GetActiveOrders(string systemUuid, string login);
    Task<MTrResponse<MTrGetLedgersResponse>> GetLedgers(string systemUuid, string login, MTrLedgerType[] types, DateTime? from, DateTime? to, int? limit);
    Task<MTrResponse<MTrGroupConfiguration>> GetGroup(string systemUuid, string name);
    Task<MTrResponse<List<string>>> GetGroupNames(string systemUuid);
    Task<MTrResponse<List<MTrRetrieveOrdersHistoryByLoginsOrGroupsResponse>>> RetrieveOrdersHistoryByLoginsOrGroups(MTrRetrieveOrdersHistoryByLoginsOrGroupsRequest request);
    Task<MTrResponse<MTrRetrieveLedgersByLoginsOrGroupsResponse>> RetrieveLedgersByLoginsOrGroups(MTrRetrieveLedgersByLoginsOrGroupsRequest request);
    Task<MTrResponse<MTrRetrieveOpenPositionsByLoginsOrGroupsResponse>> RetrieveOpenPositionsByLoginsOrGroups(MTrRetrieveOpenPositionsByLoginsOrGroupsRequest request);
    Task<MTrResponse<MTrRetrieveClosedPositionsByLoginsOrGroupsResponse>> RetrieveClosedPositionsByLoginsOrGroups(MTrRetrieveClosedPositionsByLoginsOrGroupsRequest request);
    Task<MTrResponse<List<MTrOrderHistory>>> RetrieveOrdersHistoryByIds(MTrRetrieveOrdersHistoryByIdsRequest request);
    Task<MTrResponse<MTrRetrieveOpenPositionsByIdsResponse>> RetrieveOpenPositionsByIds(MTrRetrieveOpenPositionsByIdsRequest request);
    Task<MTrResponse<MTrRetrieveClosedPositionsByLoginsOrGroupsResponse>> RetrieveClosedPositionsByIds(MTrRetrieveClosedPositionsByIdsRequest request);
    Task<MTrResponse<MTrRetrieveActiveOrdersByIdsResponse>> RetrieveActiveOrdersByIds(MTrRetrieveActiveOrdersByIdsRequest request);
    Task<MTrResponse<MTrGetCandlesResponse>> GetCandles(string systemUuid, string symbol, MTrCandleInterval interval, DateTime from, DateTime to);
}