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
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="systemUuid"></param>
    /// <param name="logins"></param>
    /// <param name="groups"></param>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <param name="limit"></param>
    /// <param name="isIncludeLocked"></param>
    /// <param name="isIncludeBlocked"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<MTrResponse<List<MTrRetrieveOpenPositionsByLoginsOrGroupsResponse>>> RetrieveOpenPositionsByLoginsOrGroups(string systemUuid, IEnumerable<string>? logins, IEnumerable<string>? groups, int? limit = null, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<MTrResponse<MTrRetrieveClosedPositionsResponse>> RetrieveClosedPositionsByLoginsOrGroups(MTrRetrieveClosedPositionsByLoginsOrGroupsRequest request, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="systemUuid"></param>
    /// <param name="login"></param>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <param name="orderIds"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<MTrResponse<List<MTrOrderHistory>>> RetrieveOrdersHistoryByIds(string systemUuid, string login, DateTimeOffset from, DateTimeOffset to, IEnumerable<string> orderIds, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="systemUuid"></param>
    /// <param name="login"></param>
    /// <param name="positionIds"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<MTrResponse<MTrRetrieveOpenPositionsByIdsResponse>> RetrieveOpenPositionsByIds(string systemUuid, string login, IEnumerable<string> positionIds, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="systemUuid"></param>
    /// <param name="login"></param>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <param name="positionIds"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<MTrResponse<MTrRetrieveClosedPositionsResponse>> RetrieveClosedPositionsByIds(string systemUuid, string login, DateTimeOffset from, DateTimeOffset to, IEnumerable<string> positionIds,  CancellationToken cancellationToken = default);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="systemUuid"></param>
    /// <param name="login"></param>
    /// <param name="orderIds"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<MTrResponse<MTrRetrieveActiveOrdersByIdsResponse>> RetrieveActiveOrdersByIds(string systemUuid, string login, IEnumerable<string> orderIds, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="systemUuid"></param>
    /// <param name="symbol"></param>
    /// <param name="interval"></param>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<MTrResponse<MTrGetCandlesResponse>> GetCandles(string systemUuid, string symbol, MTrCandleInterval interval, DateTimeOffset from, DateTimeOffset to, CancellationToken cancellationToken = default);
}