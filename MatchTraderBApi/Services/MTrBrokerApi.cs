using MatchTraderBApi.Constants.RestEndpoints;
using MatchTraderBApi.Enums;
using MatchTraderBApi.Enums.SortingFields;
using MatchTraderBApi.Exceptions;
using MatchTraderBApi.Helpers;
using MatchTraderBApi.Models.Dtos.Account;
using MatchTraderBApi.Models.Requests.Accounts;
using MatchTraderBApi.Models.Requests.General;
using MatchTraderBApi.Models.Responses;
using MatchTraderBApi.Models.Responses.Account;
using MatchTraderBApi.Models.Responses.General;
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

    public async Task<MTrResponse<MTrGetOffersResponse>> GetOffers(DateTime? from, DateTime? to, MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder)
    {
        var response = new MTrResponse<MTrGetOffersResponse>();
        try
        {
            var path = GeneralEndpoints.GetOffers(from, to, sortField, sortOrder);
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<MTrGetOffersResponse>(
                HttpClient, 
                _settings, 
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

    public async Task<MTrResponse<MTrAccount>> GetAccountByUuid(string accountUuid)
    {
        var response = new MTrResponse<MTrAccount>();
        try
        {
            var path = AccountEndpoints.GetAccountByUuid(accountUuid);
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<MTrAccount>(
                HttpClient, 
                _settings, 
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

    public async Task<MTrResponse<MTrGetAccountTimelineEventsResponse>> GetAccountTimelineEvents(string accountUuid, MTrAccountTimelineEventType? eventType, DateTime? from, DateTime? to,
        MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder)
    {
        var response = new MTrResponse<MTrGetAccountTimelineEventsResponse>();
        try
        {
            var path = AccountEndpoints.GetAccountTimelineEvents(accountUuid, eventType, from, to, sortField, sortOrder);
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<MTrGetAccountTimelineEventsResponse>(
                HttpClient,
                _settings,
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

    public async Task<MTrResponse<MTrCreateAccountResponse>> CreateAccount(MTrCreateAccountRequest request)
    {
        var response = new MTrResponse<MTrCreateAccountResponse>();
        try
        {
            var path = AccountEndpoints.CreateAccount();
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<MTrCreateAccountRequest, MTrCreateAccountResponse>(
                HttpClient,
                _settings,
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

    public async Task<MTrResponse<MTrAccount>> UpdateAccountInfo(string accountUuid, MTrUpdateAccountInfoRequest request)
    {
        var response = new MTrResponse<MTrAccount>();
        try
        {
            var path = AccountEndpoints.UpdateAccountInfo(accountUuid);
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<MTrUpdateAccountInfoRequest, MTrAccount>(
                HttpClient,
                _settings,
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

    public async Task<MTrResponse<object?>> ChangeAccountPassword(MTrChangeAccountPasswordRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<MTrResponse<MTrAddAccountNoteResponse>> AddNote(MTrAddAccountNoteRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<MTrResponse<MTrAddAccountTaskRequest>> AddTask(MTrAddAccountTaskRequest request)
    {
        throw new NotImplementedException();
    }

    #endregion

    public void Dispose()
    {
        HttpClient.Dispose();
    }
}