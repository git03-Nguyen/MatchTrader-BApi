using MatchTraderBApi.Constants.RestEndpoints;
using MatchTraderBApi.Enums;
using MatchTraderBApi.Enums.Account;
using MatchTraderBApi.Enums.SortingFields;
using MatchTraderBApi.Enums.Trading;
using MatchTraderBApi.Helpers;
using MatchTraderBApi.Models.Dtos.Account;
using MatchTraderBApi.Models.Dtos.Trading;
using MatchTraderBApi.Models.Requests.Accounts;
using MatchTraderBApi.Models.Requests.Accounts.TradingAcounts;
using MatchTraderBApi.Models.Requests.General;
using MatchTraderBApi.Models.Requests.Trading;
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
        IMTrSettingsOptions settings
    )
    {
        return new MTrBrokerApi(httpClientFactory, settings);
    }

    public HttpClient HttpClient { get; set; }
    public IMTrSettingsOptions Settings { get; set; }

    public void Dispose()
    {
        HttpClient.Dispose();
        GC.SuppressFinalize(this);
    }
    
    ~MTrBrokerApi()
    {
        HttpClient.Dispose();
    }

    private MTrBrokerApi
    (
        IHttpClientFactory httpClientFactory,
        IMTrSettingsOptions settings
    )
    {
        HttpClient = httpClientFactory.CreateClient(nameof(MTrBrokerApi));
        Settings = settings;
        HttpClient.BaseAddress = new Uri(settings.RestHost);
        HttpClient.Timeout = TimeSpan.FromMilliseconds(settings.Timeout);
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

    public Task<MTrResponse<MTrGetBranchesResponse>> GetBranches(DateTimeOffset? from, DateTimeOffset? to, MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder, CancellationToken cancellationToken = default)
    {
        var path = GeneralEndpoints.GetBranches(from?.UtcDateTime, to?.UtcDateTime, sortField, sortOrder);
        return HttpClientHelper.SendAuthorizedAsync<MTrGetBranchesResponse>(
            HttpClient,
            Settings,
            HttpMethod.Get,
            path,
            cancellationToken);
    }

    public Task<MTrResponse<MTrGetOffersResponse>> GetOffers(DateTimeOffset? from, DateTimeOffset? to, MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder, CancellationToken cancellationToken = default)
    {
        var path = GeneralEndpoints.GetOffers(from?.UtcDateTime, to?.UtcDateTime, sortField, sortOrder);
        return HttpClientHelper.SendAuthorizedAsync<MTrGetOffersResponse>(
            HttpClient,
            Settings,
            HttpMethod.Get,
            path,
            cancellationToken);
    }

    public Task<MTrResponse<MTrGetRolesResponse>> GetRoles(DateTimeOffset? from, DateTimeOffset? to, MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder, CancellationToken cancellationToken = default)
    {
        var path = GeneralEndpoints.GetRoles(from?.UtcDateTime, to?.UtcDateTime, sortField, sortOrder);
        return HttpClientHelper.SendAuthorizedAsync<MTrGetRolesResponse>(
            HttpClient,
            Settings,
            HttpMethod.Get,
            path,
            cancellationToken);
    }

    public Task<MTrResponse<MTrRetrievePlatformLogsV2Response>> RetrievePlatformLogsV2(int? page, int? size, DateTimeOffset? from, DateTimeOffset? to, MTrSortingOrder? sortOrder, MTrRetrievePlatformLogsV2Request request, CancellationToken cancellationToken = default)
    {
        var path = GeneralEndpoints.RetrievePlatformLogsV2(page, size, from?.UtcDateTime, to?.UtcDateTime, sortOrder);
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

    public Task<MTrResponse<MTrGetAccountsResponse>> GetAccounts(string? query, int? page, int? size, DateTimeOffset? from, DateTimeOffset? to, MTrAccountType? accountType,
        MTrAccountSortingField? sortField, MTrSortingOrder? sortingOrder, CancellationToken cancellationToken = default)
    {
        var path = AccountEndpoints.GetAccounts(query, page, size, from?.UtcDateTime, to?.UtcDateTime, accountType, sortField, sortingOrder);
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

    public Task<MTrResponse<MTrGetAccountTimelineEventsResponse>> GetAccountTimelineEvents(string accountUuid, MTrAccountTimelineEventType? eventType, DateTimeOffset? from, DateTimeOffset? to,
        MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder, CancellationToken cancellationToken = default)
    {
        var path = AccountEndpoints.GetAccountTimelineEvents(accountUuid, eventType, from?.UtcDateTime, to?.UtcDateTime, sortField, sortOrder);
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

    public Task<MTrResponse<object?>> ChangeAccountPassword(string accountUuid, string newPassword, CancellationToken cancellationToken = default)
    {
        var path = AccountEndpoints.ChangeAccountPassword();
        var request = new MTrChangeAccountPasswordRequest(accountUuid, newPassword);
        return HttpClientHelper.SendAuthorizedAsync<MTrChangeAccountPasswordRequest, object?>(
            HttpClient,
            Settings,
            HttpMethod.Post,
            path,
            request,
            cancellationToken);
    }

    public Task<MTrResponse<MTrAddAccountNoteResponse>> AddNote(string accountUuid, string content, MTrNoteType type, CancellationToken cancellationToken = default)
    {
        var path = AccountEndpoints.AddNote();
        var request = new MTrAddAccountNoteRequest
        {
            AccountUuid = accountUuid,
            Content = content,
            Type = type
        };
        return HttpClientHelper.SendAuthorizedAsync<MTrAddAccountNoteRequest, MTrAddAccountNoteResponse>(
            HttpClient,
            Settings,
            HttpMethod.Post,
            path,
            request,
            cancellationToken);
    }

    public Task<MTrResponse<MTrAddAccountTaskResponse>> AddTask(string accountUuid, MTrTaskType type, DateTimeOffset startDate, MTrTaskStatus status, string accountManagerUuid, string comment, CancellationToken cancellationToken = default)
    {
        var path = AccountEndpoints.AddNote();
        var request = new MTrAddAccountTaskRequest
        {
            AccountUuid = accountUuid,
            Type = type,
            StartDate = startDate.UtcDateTime,
            Status = status,
            AccountManagerUuid = accountManagerUuid,
            Comment = comment
        };
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

    public Task<MTrResponse<MTrGetTradingAccountsResponse>> GetTradingAccounts(string? query, int? page, int? size, DateTimeOffset? from, DateTimeOffset? to,
        MTrTradingAccountSortingField? sortField, MTrSortingOrder? sortOrder, CancellationToken cancellationToken = default)
    {
        var path = TradingAccountEndpoints.GetTradingAccounts(query, page, size, from?.UtcDateTime, to?.UtcDateTime, sortField, sortOrder);
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

    public Task<MTrResponse<MTrTradingAccount>> CreateNewTradingAccount(string accountUuid, string offerId, string? commissionId, CancellationToken cancellationToken = default)
    {
        var path = TradingAccountEndpoints.CreateNewTradingAccount(accountUuid);
        var request = new MTrCreateTradingAccountRequest
        {
            OfferId = offerId,
            CommissionUuid = commissionId ?? string.Empty,
        };
        return HttpClientHelper.SendAuthorizedAsync<MTrCreateTradingAccountRequest, MTrTradingAccount>(
            HttpClient,
            Settings,
            HttpMethod.Post,
            path,
            request,
            cancellationToken);
    }

    public Task<MTrResponse<object?>> UpdateTradingAccount(string systemUuid, string login, string? offerId, string? commissionId, MTrTradingAccountAccess? access, CancellationToken cancellationToken = default)
    {
        var path = TradingAccountEndpoints.UpdateTradingAccount(systemUuid, login);
        var request = new MTrUpdateTradingAccountRequest
        {
            OfferUuid = offerId,
            CommissionUuid = commissionId,
            Access = access
        };
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

    public Task<MTrResponse<MTrGetSymbolsResponse>> GetSymbols(string systemUuid, string group, IEnumerable<string>? symbols, CancellationToken cancellationToken = default)
    {
        var path = TradingEndpoints.GetSymbols(systemUuid, group, symbols);
        var response = HttpClientHelper.SendAuthorizedAsync<MTrGetSymbolsResponse>(
            HttpClient,
            Settings,
            HttpMethod.Get,
            path,
            cancellationToken);
        return response;
    }

    public Task<MTrResponse<MTrCloseAllPositionsResponse>> CloseAllPositions(string SystemUuid, IEnumerable<string> Logins, CancellationToken cancellationToken = default)
    {
        var path = TradingEndpoints.CloseAllPositions();
        var request = new MTrCloseAllPositionsRequest
        {
            SystemUuid = SystemUuid,
            Logins = Logins
        };
        var response = HttpClientHelper.SendAuthorizedAsync<MTrCloseAllPositionsRequest, MTrCloseAllPositionsResponse>(
            HttpClient,
            Settings,
            HttpMethod.Post,
            path,
            request,
            cancellationToken);
        return response;
    }

    public Task<MTrResponse<MTrGetOpenPositionsResponse>> GetOpenPositions(string systemUuid, string login, CancellationToken cancellationToken = default)
    {
        var path = TradingDataEndpoints.GetOpenPositions(systemUuid, login);
        var response = HttpClientHelper.SendAuthorizedAsync<MTrGetOpenPositionsResponse>(
            HttpClient,
            Settings,
            HttpMethod.Get,
            path,
            cancellationToken);
        return response;
    }

    public Task<MTrResponse<MTrGetClosedPositionsResponse>> GetClosedPositions(string systemUuid, string login, DateTimeOffset? from, DateTimeOffset? to, CancellationToken cancellationToken = default)
    {
        var path = TradingDataEndpoints.GetClosedPositions(systemUuid, login, from?.UtcDateTime, to?.UtcDateTime);
        var response = HttpClientHelper.SendAuthorizedAsync<MTrGetClosedPositionsResponse>(
            HttpClient,
            Settings,
            HttpMethod.Get,
            path,
            cancellationToken);
        return response;
    }

    public Task<MTrResponse<MTrGetActiveOrdersResponse>> GetActiveOrders(string systemUuid, string login, CancellationToken cancellationToken = default)
    {
        var path = TradingDataEndpoints.GetActiveOrders(systemUuid, login);
        var response = HttpClientHelper.SendAuthorizedAsync<MTrGetActiveOrdersResponse>(
            HttpClient,
            Settings,
            HttpMethod.Get,
            path,
            cancellationToken);
        return response;
    }

    public Task<MTrResponse<MTrGetLedgersResponse>> GetLedgers(string systemUuid, string login, IEnumerable<MTrLedgerType> types, DateTimeOffset? from = null, DateTimeOffset? to = null, int? limit = null, CancellationToken cancellationToken = default)
    {
        var path = TradingDataEndpoints.GetLedgers(systemUuid, login, types, from?.UtcDateTime, to?.UtcDateTime, limit);
        var response = HttpClientHelper.SendAuthorizedAsync<MTrGetLedgersResponse>(
            HttpClient,
            Settings,
            HttpMethod.Post,
            path,
            cancellationToken);
        return response;
    }

    public Task<MTrResponse<List<MTrGroupConfiguration>>> GetGroups(string systemUuid, IEnumerable<string> names, CancellationToken cancellationToken = default)
    {
        var path = TradingDataEndpoints.GetGroups(systemUuid);
        var request = new MTrGetGroupsRequest
        {
            Names = names
        };
        var response = HttpClientHelper.SendAuthorizedAsync<MTrGetGroupsRequest, List<MTrGroupConfiguration>>(
            HttpClient,
            Settings,
            HttpMethod.Post,
            path,
            request,
            cancellationToken);
        return response;
    }

    public Task<MTrResponse<List<string>>> GetGroupNames(string systemUuid, CancellationToken cancellationToken = default)
    {
        var path = TradingDataEndpoints.GetGroupNames(systemUuid);
        var response = HttpClientHelper.SendAuthorizedAsync<List<string>>(
            HttpClient,
            Settings,
            HttpMethod.Get,
            path,
            cancellationToken);
        return response;
    }

    public Task<MTrResponse<List<MTrRetrieveOrdersHistoryByLoginsOrGroupsResponse>>> RetrieveOrdersHistoryByLoginsOrGroups(string systemUuid, IEnumerable<MTrOrderStatus> statuses, IEnumerable<string>? logins, IEnumerable<string>? groups, DateTimeOffset? from = null, DateTimeOffset? to = null, int? limit = null, CancellationToken cancellationToken = default)
    {
        var path = TradingDataEndpoints.RetrieveOrdersHistoryByLoginsOrGroups();
        var request = new MTrRetrieveOrdersHistoryByLoginsOrGroupsRequest
        {
            SystemUuid = systemUuid,
            Statuses = statuses,
            Logins = logins,
            Groups = groups,
            From = from?.UtcDateTime,
            To = to?.UtcDateTime,
            Limit = limit
        };
        var response = HttpClientHelper.SendAuthorizedAsync<MTrRetrieveOrdersHistoryByLoginsOrGroupsRequest, List<MTrRetrieveOrdersHistoryByLoginsOrGroupsResponse>>(
            HttpClient,
            Settings,
            HttpMethod.Post,
            path,
            request,
            cancellationToken);
        return response;
    }

    public Task<MTrResponse<List<MTrRetrieveLedgersByLoginsOrGroupsResponse>>> RetrieveLedgersByLoginsOrGroups(string systemUuid, IEnumerable<MTrLedgerType> types, IEnumerable<string>? logins, IEnumerable<string>? groups, DateTimeOffset? from = null, DateTimeOffset? to = null, int? limit = null, CancellationToken cancellationToken = default)
    {
        var path = TradingDataEndpoints.RetrieveLedgersByLoginsOrGroups();
        var request = new MTrRetrieveLedgersByLoginsOrGroupsRequest
        {
            SystemUuid = systemUuid,
            Types = types,
            Logins = logins,
            Groups = groups,
            From = from?.UtcDateTime,
            To = to?.UtcDateTime,
            Limit = limit
        };
        var response = HttpClientHelper.SendAuthorizedAsync<MTrRetrieveLedgersByLoginsOrGroupsRequest, List<MTrRetrieveLedgersByLoginsOrGroupsResponse>>(
            HttpClient,
            Settings,
            HttpMethod.Post,
            path,
            request,
            cancellationToken);
        return response;
    }

    public Task<MTrResponse<List<MTrRetrieveOpenPositionsByLoginsOrGroupsResponse>>> RetrieveOpenPositionsByLoginsOrGroups(string systemUuid, IEnumerable<string>? logins, IEnumerable<string>? groups, int? limit = null, CancellationToken cancellationToken = default)
    {
        var path = TradingDataEndpoints.RetrieveOpenPositionsByLoginsOrGroups();
        var request = new MTrRetrieveOpenPositionsByLoginsOrGroupsRequest
        {
            SystemUuid = systemUuid,
            Logins = logins,
            Groups = groups,
            Limit = limit
        };
        var response = HttpClientHelper.SendAuthorizedAsync<MTrRetrieveOpenPositionsByLoginsOrGroupsRequest, List<MTrRetrieveOpenPositionsByLoginsOrGroupsResponse>>(
            HttpClient,
            Settings,
            HttpMethod.Post,
            path,
            request,
            cancellationToken);
        return response;
    }

    public Task<MTrResponse<List<MTrRetrieveClosedPositionsResponse>>> RetrieveClosedPositionsByLoginsOrGroups(string systemUuid, IEnumerable<string>? logins, IEnumerable<string>? groups, DateTimeOffset from, DateTimeOffset to, int? limit, bool isIncludeLocked = true, bool isIncludeBlocked = false, CancellationToken cancellationToken = default)
    {
        var path = TradingDataEndpoints.RetrieveClosedPositionsByLoginsOrGroups();
        var request = new MTrRetrieveClosedPositionsByLoginsOrGroupsRequest
        {
            SystemUuid = systemUuid,
            Logins = logins,
            Groups = groups,
            From = from.UtcDateTime,
            To = to.UtcDateTime,
            IsIncludeLocked = isIncludeLocked,
            IsIncludeBlocked = isIncludeBlocked,
            Limit = limit
        };
        var response = HttpClientHelper.SendAuthorizedAsync<MTrRetrieveClosedPositionsByLoginsOrGroupsRequest, List<MTrRetrieveClosedPositionsResponse>>(
            HttpClient,
            Settings,
            HttpMethod.Post,
            path,
            request,
            cancellationToken);
        return response;
    }

    // TODO: The API Key seems to be not enough permission to use this endpoint
    public Task<MTrResponse<List<MTrOrderHistory>>> RetrieveOrdersHistoryByIds(string systemUuid, string login, DateTimeOffset from, DateTimeOffset to, IEnumerable<string> orderIds, CancellationToken cancellationToken = default)
    {
        var path = TradingDataEndpoints.RetrieveOrdersHistoryByIds();
        var request = new MTrRetrieveOrdersHistoryByIdsRequest
        {
            SystemUuid = systemUuid,
            Login = login,
            From = from.UtcDateTime,
            To = to.UtcDateTime,
            OrderIds = orderIds
        };
        var response = HttpClientHelper.SendAuthorizedAsync<MTrRetrieveOrdersHistoryByIdsRequest, List<MTrOrderHistory>>(
            HttpClient,
            Settings,
            HttpMethod.Post,
            path,
            request,
            cancellationToken);
        return response;
    }

    // TODO: The API Key seems to be not enough permission to use this endpoint
    public Task<MTrResponse<MTrRetrieveOpenPositionsByIdsResponse>> RetrieveOpenPositionsByIds(string systemUuid, string login, IEnumerable<string> positionIds, CancellationToken cancellationToken = default)
    {
        var path = TradingDataEndpoints.RetrieveOpenPositionsByIds();
        var request = new MTrRetrieveOpenPositionsByIdsRequest
        {
            SystemUuid = systemUuid,
            Login = login,
            PositionIds = positionIds.ToList()
        };
        var response = HttpClientHelper.SendAuthorizedAsync<MTrRetrieveOpenPositionsByIdsRequest, MTrRetrieveOpenPositionsByIdsResponse>(
            HttpClient,
            Settings,
            HttpMethod.Post,
            path,
            request,
            cancellationToken);
        return response;
    }

    // TODO: The API Key seems to be not enough permission to use this endpoint
    public Task<MTrResponse<MTrRetrieveClosedPositionsResponse>> RetrieveClosedPositionsByIds(string systemUuid, string login, DateTimeOffset from, DateTimeOffset to, IEnumerable<string> positionIds, CancellationToken cancellationToken = default)
    {
        var path = TradingDataEndpoints.RetrieveClosedPositionsByIds();
        var request = new MTrRetrieveClosedPositionsByIdsRequest
        {
            SystemUuid = systemUuid,
            Login = login,
            PositionIds = positionIds.ToList(),
            From = from.UtcDateTime,
            To = to.UtcDateTime
        };
        var response = HttpClientHelper.SendAuthorizedAsync<MTrRetrieveClosedPositionsByIdsRequest, MTrRetrieveClosedPositionsResponse>(
            HttpClient,
            Settings,
            HttpMethod.Post,
            path,
            request,
            cancellationToken);
        return response;
    }

    // TODO: The API Key seems to be not enough permission to use this endpoint
    public Task<MTrResponse<MTrRetrieveActiveOrdersByIdsResponse>> RetrieveActiveOrdersByIds(string systemUuid, string login, IEnumerable<string> orderIds, CancellationToken cancellationToken = default)
    {
        var path = TradingDataEndpoints.RetrieveActiveOrdersByIds();
        var request = new MTrRetrieveActiveOrdersByIdsRequest
        {
            SystemUuid = systemUuid,
            Login = login,
            OrderIds = orderIds.ToList()
        };
        var response = HttpClientHelper.SendAuthorizedAsync<MTrRetrieveActiveOrdersByIdsRequest, MTrRetrieveActiveOrdersByIdsResponse>(
            HttpClient,
            Settings,
            HttpMethod.Post,
            path,
            request,
            cancellationToken);
        return response;
    }

    public Task<MTrResponse<MTrGetCandlesResponse>> GetCandles(string systemUuid, string symbol, MTrCandleInterval interval, DateTimeOffset from, DateTimeOffset to, CancellationToken cancellationToken = default)
    {
        var path = TradingDataEndpoints.GetCandles(systemUuid, symbol, interval, from.UtcDateTime, to.UtcDateTime);
        var response = HttpClientHelper.SendAuthorizedAsync<MTrGetCandlesResponse>(
            HttpClient,
            Settings,
            HttpMethod.Get,
            path,
            cancellationToken);
        return response;
    }

    #endregion
}