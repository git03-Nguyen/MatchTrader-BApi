using MatchTraderBApi.Constants.RestEndpoints;
using MatchTraderBApi.Enums;
using MatchTraderBApi.Enums.SortingFields;
using MatchTraderBApi.Helpers;
using MatchTraderBApi.Models.Dtos.Account;
using MatchTraderBApi.Models.Dtos.Trading;
using MatchTraderBApi.Models.Requests.Accounts;
using MatchTraderBApi.Models.Requests.Accounts.TradingAcounts;
using MatchTraderBApi.Models.Requests.General;
using MatchTraderBApi.Models.Requests.Trading.TradingData;
using MatchTraderBApi.Models.Responses;
using MatchTraderBApi.Models.Responses.Account;
using MatchTraderBApi.Models.Responses.Account.TradingAccount;
using MatchTraderBApi.Models.Responses.General;
using MatchTraderBApi.Models.Responses.Trading;
using MatchTraderBApi.Models.Responses.Trading.TradingData;
using MatchTraderBApi.Models.Responses.Trading.TradingData.Candle;
using MatchTraderBApi.Options;

namespace MatchTraderBApi.Services;

public class MTrBrokerApi : IMTrBrokerApi
{
    public static MTrBrokerApi Create
    (
        IHttpClientFactory httpClientFactory,
        MTrSettingsOptions settings
    )
    {
        return new MTrBrokerApi(httpClientFactory, settings);
    }
    
    public HttpClient HttpClient { get; set; }
    public MTrSettingsOptions Settings { get; set; }
    private MTrBrokerApi
    (
        IHttpClientFactory httpClientFactory,
        MTrSettingsOptions settings
    )
    {
        HttpClient = httpClientFactory.CreateClient(nameof(MTrBrokerApi));
        Settings = settings;
        HttpClient.BaseAddress = new Uri(settings.RestHost);
        HttpClient.Timeout = TimeSpan.FromMilliseconds(settings.Timeout);
    }
    
    public void Dispose()
    {
        HttpClient.Dispose();
    }
    
    #region General

    public Task<MTrResponse<MTrGetServiceInfoResponse>> GetServiceInfo(CancellationToken cancellationToken = default)
    {
        var path = GeneralEndpoints.ServiceInfo();
        return HttpClientHelper.SendAuthorizedAsync<MTrGetServiceInfoResponse>(
            HttpClient,
            Settings,
            HttpMethod.Get,
            path,
            cancellationToken);
    }

    public Task<MTrResponse<MTrGetBranchesResponse>> GetBranches(DateTime? from, DateTime? to, MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder, CancellationToken cancellationToken = default)
    {
        var path = GeneralEndpoints.GetBranches(from, to, sortField, sortOrder);
        return HttpClientHelper.SendAuthorizedAsync<MTrGetBranchesResponse>(
            HttpClient,
            Settings,
            HttpMethod.Get,
            path,
            cancellationToken);
    }

    public Task<MTrResponse<MTrGetOffersResponse>> GetOffers(DateTime? from, DateTime? to, MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder, CancellationToken cancellationToken = default)
    {
        var path = GeneralEndpoints.GetOffers(from, to, sortField, sortOrder);
        return HttpClientHelper.SendAuthorizedAsync<MTrGetOffersResponse>(
            HttpClient,
            Settings,
            HttpMethod.Get,
            path,
            cancellationToken);
    }

    public Task<MTrResponse<MTrGetRolesResponse>> GetRoles(DateTime? from, DateTime? to, MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder, CancellationToken cancellationToken = default)
    {
        var path = GeneralEndpoints.GetRoles(from, to, sortField, sortOrder);
        return HttpClientHelper.SendAuthorizedAsync<MTrGetRolesResponse>(
            HttpClient,
            Settings,
            HttpMethod.Get,
            path,
            cancellationToken);
    }

    public Task<MTrResponse<MTrRetrievePlatformLogsV2Response>> RetrievePlatformLogsV2(int? page, int? size, DateTime? from, DateTime? to, MTrSortingOrder? sortOrder, MTrRetrievePlatformLogsV2Request request, CancellationToken cancellationToken = default)
    {
        var path = GeneralEndpoints.RetrievePlatformLogsV2(page, size, from, to, sortOrder);
        return HttpClientHelper.SendAuthorizedAsync<MTrRetrievePlatformLogsV2Request, MTrRetrievePlatformLogsV2Response>(
            HttpClient,
            Settings,
            HttpMethod.Post,
            path,
            request,
            cancellationToken);
    }

    #endregion
    
    #region Accounts

    public Task<MTrResponse<MTrGetAccountsResponse>> GetAccounts(string? query, int? page, int? size, DateTime? from, DateTime? to, MTrAccountType? accountType,
        MTrAccountSortingField? sortField, MTrSortingOrder? sortingOrder, CancellationToken cancellationToken = default)
    {
        var path = AccountEndpoints.GetAccounts(query, page, size, from, to, accountType, sortField, sortingOrder);
        return HttpClientHelper.SendAuthorizedAsync<MTrGetAccountsResponse>(
            HttpClient,
            Settings,
            HttpMethod.Get,
            path,
            cancellationToken);
    }

    public Task<MTrResponse<MTrAccount>> GetAccountByEmail(string email, CancellationToken cancellationToken = default)
    {
        var path = AccountEndpoints.GetAccountByEmail(email);
        return HttpClientHelper.SendAuthorizedAsync<MTrAccount>(
            HttpClient,
            Settings,
            HttpMethod.Get,
            path,
            cancellationToken);
    }

    public Task<MTrResponse<MTrAccount>> GetAccountByUuid(string accountUuid, CancellationToken cancellationToken = default)
    {
        var path = AccountEndpoints.GetAccountByUuid(accountUuid);
        return HttpClientHelper.SendAuthorizedAsync<MTrAccount>(
            HttpClient,
            Settings,
            HttpMethod.Get,
            path,
            cancellationToken);
    }

    public Task<MTrResponse<MTrGetAccountTimelineEventsResponse>> GetAccountTimelineEvents(string accountUuid, MTrAccountTimelineEventType? eventType, DateTime? from, DateTime? to,
        MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder, CancellationToken cancellationToken = default)
    {
        var path = AccountEndpoints.GetAccountTimelineEvents(accountUuid, eventType, from, to, sortField, sortOrder);
        return HttpClientHelper.SendAuthorizedAsync<MTrGetAccountTimelineEventsResponse>(
            HttpClient,
            Settings,
            HttpMethod.Get,
            path,
            cancellationToken);
    }

    public Task<MTrResponse<MTrCreateAccountResponse>> CreateAccount(MTrCreateAccountRequest request, CancellationToken cancellationToken = default)
    {
        var path = AccountEndpoints.CreateAccount();
        return HttpClientHelper.SendAuthorizedAsync<MTrCreateAccountRequest, MTrCreateAccountResponse>(
            HttpClient,
            Settings,
            HttpMethod.Post,
            path,
            request,
            cancellationToken);
    }

    public Task<MTrResponse<MTrAccount>> UpdateAccountInfo(string accountUuid, MTrUpdateAccountInfoRequest request, CancellationToken cancellationToken = default)
    {
        var path = AccountEndpoints.UpdateAccountInfo(accountUuid);
        return HttpClientHelper.SendAuthorizedAsync<MTrUpdateAccountInfoRequest, MTrAccount>(
            HttpClient,
            Settings,
            HttpMethod.Patch,
            path,
            request,
            cancellationToken);
    }

    public Task<MTrResponse<object?>> ChangeAccountPassword(MTrChangeAccountPasswordRequest request, CancellationToken cancellationToken = default)
    {
        var path = AccountEndpoints.ChangeAccountPassword();
        return HttpClientHelper.SendAuthorizedAsync<MTrChangeAccountPasswordRequest, object?>(
            HttpClient,
            Settings,
            HttpMethod.Post,
            path,
            request,
            cancellationToken);
    }

    public Task<MTrResponse<MTrAddAccountNoteResponse>> AddNote(MTrAddAccountNoteRequest request, CancellationToken cancellationToken = default)
    {
        var path = AccountEndpoints.AddNote();
        return HttpClientHelper.SendAuthorizedAsync<MTrAddAccountNoteRequest, MTrAddAccountNoteResponse>(
            HttpClient,
            Settings,
            HttpMethod.Post,
            path,
            request,
            cancellationToken);
    }

    public Task<MTrResponse<MTrAddAccountTaskResponse>> AddTask(MTrAddAccountTaskRequest request, CancellationToken cancellationToken = default)
    {
        var path = AccountEndpoints.AddNote();
        return HttpClientHelper.SendAuthorizedAsync<MTrAddAccountTaskRequest, MTrAddAccountTaskResponse>(
            HttpClient,
            Settings,
            HttpMethod.Post,
            path,
            request,
            cancellationToken);
    }

    #endregion

    #region Trading Accounts
    
    public Task<MTrResponse<MTrGetTradingAccountsResponse>> GetTradingAccounts(string? query, int? page, int? size, DateTime? from, DateTime? to,
        MTrTradingAccountSortingField? sortField, MTrSortingOrder? sortOrder, CancellationToken cancellationToken = default)
    {
        var path = TradingAccountEndpoints.GetTradingAccounts(query, page, size, from, to, sortField, sortOrder);
        return HttpClientHelper.SendAuthorizedAsync<MTrGetTradingAccountsResponse>(
            HttpClient,
            Settings,
            HttpMethod.Get,
            path,
            cancellationToken);
    }

    public Task<MTrResponse<MTrTradingAccount>> GetTradingAccountByLogin(string systemUuid, string login, CancellationToken cancellationToken = default)
    {
        var path = TradingAccountEndpoints.GetTradingAccountByLogin(systemUuid, login);
        return HttpClientHelper.SendAuthorizedAsync<MTrTradingAccount>(
            HttpClient,
            Settings,
            HttpMethod.Get,
            path,
            cancellationToken);
    }

    public Task<MTrResponse<MTrTradingAccount>> CreateNewTradingAccount(string accountUuid, MTrCreateTradingAccountRequest request, CancellationToken cancellationToken = default)
    {
        var path = TradingAccountEndpoints.CreateNewTradingAccount(accountUuid);
        return HttpClientHelper.SendAuthorizedAsync<MTrCreateTradingAccountRequest, MTrTradingAccount>(
            HttpClient,
            Settings,
            HttpMethod.Post,
            path,
            request,
            cancellationToken);
    }

    public Task<MTrResponse<object?>> UpdateTradingAccount(string systemUuid, string login, MTrUpdateTradingAccountRequest request, CancellationToken cancellationToken = default)
    {
        var path = TradingAccountEndpoints.UpdateTradingAccount(systemUuid, login);
        return HttpClientHelper.SendAuthorizedAsync<MTrUpdateTradingAccountRequest, object?>(
            HttpClient,
            Settings,
            HttpMethod.Patch,
            path,
            request,
            cancellationToken);
    }

    public Task<MTrResponse<object?>> ChangeLeverage(string systemUuid, string login, uint leverage, CancellationToken cancellationToken = default)
    {
        var path = TradingAccountEndpoints.ChangeLeverage(systemUuid, login);
        var request = new MTrChangeTradingAccountLeverageRequest
        {
            Leverage = leverage
        };
        return HttpClientHelper.SendAuthorizedAsync<MTrChangeTradingAccountLeverageRequest, object?>(
            HttpClient,
            Settings,
            HttpMethod.Patch,
            path,
            request,
            cancellationToken);
    }

    #endregion
    
    
    #region Trading

    public async Task<MTrResponse<MTrGetSymbolsResponse>> GetSymbols(string SystemUuid, string Group, string[]? Symbols, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<MTrResponse<MTrCloseAllPositionsResponse>> CloseAllPositions(string SystemUuid, string[] Logins, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<MTrResponse<MTrGetOpenPositionsResponse>> GetOpenPositions(string systemUuid, string login, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<MTrResponse<MTrGetClosedPositionsResponse>> GetClosedPositions(string systemUuid, string login, DateTime? from, DateTime? to, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<MTrResponse<MTrGetActiveOrdersResponse>> GetActiveOrders(string systemUuid, string login, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<MTrResponse<MTrGetLedgersResponse>> GetLedgers(string systemUuid, string login, MTrLedgerType[] types, DateTime? from, DateTime? to, int? limit, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<MTrResponse<MTrGroupConfiguration>> GetGroup(string systemUuid, string name, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<MTrResponse<List<string>>> GetGroupNames(string systemUuid, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<MTrResponse<List<MTrRetrieveOrdersHistoryByLoginsOrGroupsResponse>>> RetrieveOrdersHistoryByLoginsOrGroups(MTrRetrieveOrdersHistoryByLoginsOrGroupsRequest request, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<MTrResponse<MTrRetrieveLedgersByLoginsOrGroupsResponse>> RetrieveLedgersByLoginsOrGroups(MTrRetrieveLedgersByLoginsOrGroupsRequest request, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<MTrResponse<MTrRetrieveOpenPositionsByLoginsOrGroupsResponse>> RetrieveOpenPositionsByLoginsOrGroups(MTrRetrieveOpenPositionsByLoginsOrGroupsRequest request, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<MTrResponse<MTrRetrieveClosedPositionsByLoginsOrGroupsResponse>> RetrieveClosedPositionsByLoginsOrGroups(MTrRetrieveClosedPositionsByLoginsOrGroupsRequest request, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<MTrResponse<List<MTrOrderHistory>>> RetrieveOrdersHistoryByIds(MTrRetrieveOrdersHistoryByIdsRequest request, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<MTrResponse<MTrRetrieveOpenPositionsByIdsResponse>> RetrieveOpenPositionsByIds(MTrRetrieveOpenPositionsByIdsRequest request, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<MTrResponse<MTrRetrieveClosedPositionsByLoginsOrGroupsResponse>> RetrieveClosedPositionsByIds(MTrRetrieveClosedPositionsByIdsRequest request, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<MTrResponse<MTrRetrieveActiveOrdersByIdsResponse>> RetrieveActiveOrdersByIds(MTrRetrieveActiveOrdersByIdsRequest request, CancellationToken cancellationToken = default)
    {
        var path = TradingDataEndpoints.RetrieveActiveOrdersByIds();
        var response = await HttpClientHelper.SendAuthorizedAsync<MTrRetrieveActiveOrdersByIdsRequest, MTrRetrieveActiveOrdersByIdsResponse>(
            HttpClient,
            Settings,
            HttpMethod.Post,
            path,
            request,
            cancellationToken);
        return response;
        // try
        // {
        //     
        //     var mtrResponse = 
        //     response.Data = mtrResponse;
        //     response.RetCode = MTrRetCode.MTrRet200Ok;
        // }
        // catch (MTrRequestException ex)
        // {
        //     response.RetCode = ex.MTrRetCode;
        // }
        // catch (Exception ex)
        // {
        //     response.RetCode = MTrRetCode.MTrRet500InternalError;
        // }
        //
        // return response;
    }

    public async Task<MTrResponse<MTrGetCandlesResponse>> GetCandles(string systemUuid, string symbol, MTrCandleInterval interval, DateTime from, DateTime to, CancellationToken cancellationToken = default)
    {
        var response = new MTrResponse<MTrGetCandlesResponse>();
        try
        {
            var path = TradingDataEndpoints.GetCandles(systemUuid, symbol, interval, from, to);
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<MTrGetCandlesResponse>(
                HttpClient,
                Settings,
                HttpMethod.Get, 
                path,
                cancellationToken);
            response.RetData = mtrResponse;
            response.RetCode = MTrRetCode.MTrRet200Ok;
        }
        catch (Exception ex)
        {
            response.RetCode = MTrRetCode.MTrRet500InternalError;
        }

        return response;
    }

    #endregion
}