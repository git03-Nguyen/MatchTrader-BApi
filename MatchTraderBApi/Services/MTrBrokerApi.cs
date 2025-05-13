using MatchTraderBApi.Constants.RestEndpoints;
using MatchTraderBApi.Enums;
using MatchTraderBApi.Enums.SortingFields;
using MatchTraderBApi.Exceptions;
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

    public async Task<MTrResponse<MTrGetServiceInfoResponse>> GetServiceInfo()
    {
        var response = new MTrResponse<MTrGetServiceInfoResponse>();
        try
        {
            var path = GeneralEndpoints.ServiceInfo();
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<MTrGetServiceInfoResponse>(
                HttpClient, 
                Settings, 
                HttpMethod.Get, 
                path, 
                CancellationToken.None);
            response.RetData = mtrResponse;
            response.RetCode = MTrRetCode.MTrRet200Ok;
        }
        catch (Exception ex)
        {
            response.RetCode = MTrRetCode.MTrRet500InternalError;
        }

        return response;
    }

    public async Task<MTrResponse<MTrGetBranchesResponse>> GetBranches(DateTime? from, DateTime? to, MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder)
    {
        var response = new MTrResponse<MTrGetBranchesResponse>();
        try
        {
            var path = GeneralEndpoints.GetBranches(from, to, sortField, sortOrder);
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<MTrGetBranchesResponse>(
                HttpClient, 
                Settings, 
                HttpMethod.Get, 
                path,
                CancellationToken.None);
            response.RetData = mtrResponse;
            response.RetCode = MTrRetCode.MTrRet200Ok;
        }
        catch (Exception ex)
        {
            response.RetCode = MTrRetCode.MTrRet500InternalError;
        }

        return response;
    }

    public async Task<MTrResponse<MTrGetOffersResponse>> GetOffers(DateTime? from, DateTime? to, MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder)
    {
        var response = new MTrResponse<MTrGetOffersResponse>();
        try
        {
            var path = GeneralEndpoints.GetOffers(from, to, sortField, sortOrder);
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<MTrGetOffersResponse>(
                HttpClient, 
                Settings, 
                HttpMethod.Get, 
                path,
                CancellationToken.None);
            response.RetData = mtrResponse;
            response.RetCode = MTrRetCode.MTrRet200Ok;
        }
        catch (Exception ex)
        {
            response.RetCode = MTrRetCode.MTrRet500InternalError;
        }

        return response;
    }

    public async Task<MTrResponse<MTrGetRolesResponse>> GetRoles(DateTime? from, DateTime? to, MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder)
    {
        var response = new MTrResponse<MTrGetRolesResponse>();
        try
        {
            var path = GeneralEndpoints.GetRoles(from, to, sortField, sortOrder);
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<MTrGetRolesResponse>(
                HttpClient, 
                Settings, 
                HttpMethod.Get, 
                path,
                CancellationToken.None);
            response.RetData = mtrResponse;
            response.RetCode = MTrRetCode.MTrRet200Ok;
        }
        catch (Exception ex)
        {
            response.RetCode = MTrRetCode.MTrRet500InternalError;
        }

        return response;
    }

    public async Task<MTrResponse<MTrRetrievePlatformLogsV2Response>> RetrievePlatformLogsV2(int? page, int? size, DateTime? from, DateTime? to, MTrSortingOrder? sortOrder, MTrRetrievePlatformLogsV2Request request)
    {
        var response = new MTrResponse<MTrRetrievePlatformLogsV2Response>();
        try
        {
            var path = GeneralEndpoints.RetrievePlatformLogsV2(page, size, from, to, sortOrder);
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<MTrRetrievePlatformLogsV2Request, MTrRetrievePlatformLogsV2Response>(
                HttpClient, 
                Settings, 
                HttpMethod.Post,
                path,
                request,
                CancellationToken.None);
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
    
    #region Accounts

    public async Task<MTrResponse<MTrGetAccountsResponse>> GetAccounts(string? query, int? page, int? size, DateTime? from, DateTime? to, MTrAccountType? accountType,
        MTrAccountSortingField? sortField, MTrSortingOrder? sortingOrder)
    {
        var response = new MTrResponse<MTrGetAccountsResponse>();
        try
        {
            var path = AccountEndpoints.GetAccounts(query, page, size, from, to, accountType, sortField, sortingOrder);
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<MTrGetAccountsResponse>(
                HttpClient, 
                Settings, 
                HttpMethod.Get, 
                path, 
                CancellationToken.None);
            response.RetData = mtrResponse;
            response.RetCode = MTrRetCode.MTrRet200Ok;
        }
        catch (Exception ex)
        {
            response.RetCode = MTrRetCode.MTrRet500InternalError;
        }

        return response;
    }

    public async Task<MTrResponse<MTrAccount>> GetAccountByEmail(string email)
    {
        var response = new MTrResponse<MTrAccount>();
        try
        {
            var path = AccountEndpoints.GetAccountByEmail(email);
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<MTrAccount>(
                HttpClient, 
                Settings, 
                HttpMethod.Get, 
                path, 
                CancellationToken.None);
            response.RetData = mtrResponse;
            response.RetCode = MTrRetCode.MTrRet200Ok;
        }
        catch (Exception ex)
        {
            response.RetCode = MTrRetCode.MTrRet500InternalError;
        }

        return response;
    }

    public async Task<MTrResponse<MTrAccount>> GetAccountByUuid(string accountUuid)
    {
        var response = new MTrResponse<MTrAccount>();
        try
        {
            var path = AccountEndpoints.GetAccountByUuid(accountUuid);
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<MTrAccount>(
                HttpClient, 
                Settings, 
                HttpMethod.Get, 
                path, 
                CancellationToken.None);
            response.RetData = mtrResponse;
            response.RetCode = MTrRetCode.MTrRet200Ok;
        }
        catch (Exception ex)
        {
            response.RetCode = MTrRetCode.MTrRet500InternalError;
        }

        return response;
    }

    public async Task<MTrResponse<MTrGetAccountTimelineEventsResponse>> GetAccountTimelineEvents(string accountUuid, MTrAccountTimelineEventType? eventType, DateTime? from, DateTime? to,
        MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder)
    {
        var response = new MTrResponse<MTrGetAccountTimelineEventsResponse>();
        try
        {
            var path = AccountEndpoints.GetAccountTimelineEvents(accountUuid, eventType, from, to, sortField, sortOrder);
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<MTrGetAccountTimelineEventsResponse>(
                HttpClient,
                Settings,
                HttpMethod.Get,
                path,
                CancellationToken.None);
            response.RetData = mtrResponse;
            response.RetCode = MTrRetCode.MTrRet200Ok;
        }
        catch (Exception ex)
        {
            response.RetCode = MTrRetCode.MTrRet500InternalError;
        }

        return response;
    }

    public async Task<MTrResponse<MTrCreateAccountResponse>> CreateAccount(MTrCreateAccountRequest request)
    {
        var response = new MTrResponse<MTrCreateAccountResponse>();
        try
        {
            var path = AccountEndpoints.CreateAccount();
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<MTrCreateAccountRequest, MTrCreateAccountResponse>(
                HttpClient,
                Settings,
                HttpMethod.Post,
                path,
                request,
                CancellationToken.None);
            response.RetData = mtrResponse;
            response.RetCode = MTrRetCode.MTrRet200Ok;
        }
        catch (Exception ex)
        {
            response.RetCode = MTrRetCode.MTrRet500InternalError;
        }

        return response;
    }

    public async Task<MTrResponse<MTrAccount>> UpdateAccountInfo(string accountUuid, MTrUpdateAccountInfoRequest request)
    {
        var response = new MTrResponse<MTrAccount>();
        try
        {
            var path = AccountEndpoints.UpdateAccountInfo(accountUuid);
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<MTrUpdateAccountInfoRequest, MTrAccount>(
                HttpClient,
                Settings,
                HttpMethod.Patch,
                path,
                request,
                CancellationToken.None);
            response.RetData = mtrResponse;
            response.RetCode = MTrRetCode.MTrRet200Ok;
        }
        catch (Exception ex)
        {
            response.RetCode = MTrRetCode.MTrRet500InternalError;
        }

        return response;
    }

    public async Task<MTrResponse<object?>> ChangeAccountPassword(MTrChangeAccountPasswordRequest request)
    {
        var response = new MTrResponse<object?>();
        try
        {
            var path = AccountEndpoints.ChangeAccountPassword();
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<MTrChangeAccountPasswordRequest, object?>(
                HttpClient,
                Settings,
                HttpMethod.Post,
                path,
                request,
                CancellationToken.None);
            response.Data = mtrResponse;
            response.RetCode = MTrRetCode.MTrRet200Ok;
        }
        catch (MTrRequestException ex)
        {
            response.RetCode = ex.MTrRetCode;
        }
        catch (Exception ex)
        {
            response.RetCode = MTrRetCode.MTrRet500InternalError;
        }

        return response;
    }

    public async Task<MTrResponse<MTrAddAccountNoteResponse>> AddNote(MTrAddAccountNoteRequest request)
    {
        var response = new MTrResponse<MTrAddAccountNoteResponse>();
        try
        {
            var path = AccountEndpoints.AddNote();
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<MTrAddAccountNoteRequest, MTrAddAccountNoteResponse>(
                HttpClient,
                Settings,
                HttpMethod.Post,
                path,
                request,
                CancellationToken.None);
            response.Data = mtrResponse;
            response.RetCode = MTrRetCode.MTrRet200Ok;
        }
        catch (MTrRequestException ex)
        {
            response.RetCode = ex.MTrRetCode;
        }
        catch (Exception ex)
        {
            response.RetCode = MTrRetCode.MTrRet500InternalError;
        }

        return response;
    }

    public async Task<MTrResponse<MTrAddAccountTaskResponse>> AddTask(MTrAddAccountTaskRequest request)
    {
        var response = new MTrResponse<MTrAddAccountTaskResponse>();
        try
        {
            var path = AccountEndpoints.AddNote();
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<MTrAddAccountTaskRequest, MTrAddAccountTaskResponse>(
                HttpClient,
                Settings,
                HttpMethod.Post,
                path,
                request,
                CancellationToken.None);
            response.Data = mtrResponse;
            response.RetCode = MTrRetCode.MTrRet200Ok;
        }
        catch (MTrRequestException ex)
        {
            response.RetCode = ex.MTrRetCode;
        }
        catch (Exception ex)
        {
            response.RetCode = MTrRetCode.MTrRet500InternalError;
        }

        return response;
    }

    #endregion

    #region Trading Accounts
    
    public async Task<MTrResponse<MTrGetTradingAccountsResponse>> GetTradingAccounts(string? query, int? page, int? size, DateTime? from, DateTime? to,
        MTrTradingAccountSortingField? sortField, MTrSortingOrder? sortOrder)
    {
        var response = new MTrResponse<MTrGetTradingAccountsResponse>();
        try
        {
            var path = TradingAccountEndpoints.GetTradingAccounts(query, page, size, from, to, sortField, sortOrder);
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<MTrGetTradingAccountsResponse>(
                HttpClient, 
                Settings, 
                HttpMethod.Get, 
                path, 
                CancellationToken.None);
            response.Data = mtrResponse;
            response.RetCode = MTrRetCode.MTrRet200Ok;
        }
        catch (MTrRequestException ex)
        {
            response.RetCode = ex.MTrRetCode;
        }
        catch (Exception ex)
        {
            response.RetCode = MTrRetCode.MTrRet500InternalError;
        }

        return response;
    }

    public async Task<MTrResponse<MTrTradingAccount>> GetTradingAccountByLogin(string systemUuid, string login)
    {
        var response = new MTrResponse<MTrTradingAccount>();
        try
        {
            var path = TradingAccountEndpoints.GetTradingAccountByLogin(systemUuid, login);
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<MTrTradingAccount>(
                HttpClient, 
                Settings, 
                HttpMethod.Get, 
                path, 
                CancellationToken.None);
            response.Data = mtrResponse;
            response.RetCode = MTrRetCode.MTrRet200Ok;
        }
        catch (MTrRequestException ex)
        {
            response.RetCode = ex.MTrRetCode;
        }
        catch (Exception ex)
        {
            response.RetCode = MTrRetCode.MTrRet500InternalError;
        }

        return response;
    }

    public async Task<MTrResponse<MTrTradingAccount>> CreateNewTradingAccount(string accountUuid, MTrCreateTradingAccountRequest request)
    {
        var response = new MTrResponse<MTrTradingAccount>();
        try
        {
            var path = TradingAccountEndpoints.CreateNewTradingAccount(accountUuid);
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<MTrCreateTradingAccountRequest, MTrTradingAccount>(
                HttpClient, 
                Settings, 
                HttpMethod.Post, 
                path, 
                request,
                CancellationToken.None);
            response.Data = mtrResponse;
            response.RetCode = MTrRetCode.MTrRet200Ok;
        }
        catch (MTrRequestException ex)
        {
            response.RetCode = ex.MTrRetCode;
        }
        catch (Exception ex)
        {
            response.RetCode = MTrRetCode.MTrRet500InternalError;
        }

        return response;
    }

    public async Task<MTrResponse<string>> UpdateTradingAccount(string systemUuid, string login, MTrUpdateTradingAccountRequest request)
    {
        var response = new MTrResponse<string>();
        try
        {
            var path = TradingAccountEndpoints.UpdateTradingAccount(systemUuid, login);
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<MTrUpdateTradingAccountRequest, string>(
                HttpClient, 
                Settings, 
                HttpMethod.Patch, 
                path, 
                request,
                CancellationToken.None);
            response.Data = mtrResponse;
            response.RetCode = MTrRetCode.MTrRet200Ok;
        }
        catch (MTrRequestException ex)
        {
            response.RetCode = ex.MTrRetCode;
        }
        catch (Exception ex)
        {
            response.RetCode = MTrRetCode.MTrRet500InternalError;
        }

        return response;
    }

    public async Task<MTrResponse<string>> ChangeLeverage(string systemUuid, string login, uint leverage)
    {
        var response = new MTrResponse<string>();
        try
        {
            var path = TradingAccountEndpoints.ChangeLeverage(systemUuid, login);
            var request = new MTrChangeTradingAccountLeverageRequest
            {
                Leverage = leverage
            };
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<MTrChangeTradingAccountLeverageRequest, string>(
                HttpClient, 
                Settings, 
                HttpMethod.Patch, 
                path, 
                request,
                CancellationToken.None);
            response.Data = mtrResponse;
            response.RetCode = MTrRetCode.MTrRet200Ok;
        }
        catch (MTrRequestException ex)
        {
            response.RetCode = ex.MTrRetCode;
        }
        catch (Exception ex)
        {
            response.RetCode = MTrRetCode.MTrRet500InternalError;
        }

        return response;
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