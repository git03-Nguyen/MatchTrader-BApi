using MatchTraderBApi.Enums;
using MatchTraderBApi.Enums.SortingFields;
using MatchTraderBApi.Models.Dtos.Account;
using MatchTraderBApi.Models.Requests.Accounts;
using MatchTraderBApi.Models.Responses;
using MatchTraderBApi.Models.Responses.Account;

namespace MatchTraderBApi.Services.Interfaces;

public interface IMTrAccountApi
{
    Task<MTrResponse<MTrGetAccountsResponse>> GetAccounts(string? query, int? page, int? size, DateTime? from, DateTime? to, MTrAccountType? accountType, MTrAccountSortingField? sortField, MTrSortingOrder? sortingOrder);
    Task<MTrResponse<MTrAccount>> GetAccountByEmail(string email);
    Task<MTrResponse<MTrAccount>> GetAccountByUuid(string accountUuid);
    Task<MTrResponse<MTrGetAccountTimelineEventsResponse>> GetAccountTimelineEvents(string accountUuid, MTrAccountTimelineEventType? eventType, DateTime? from, DateTime? to, MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder);
    Task<MTrResponse<MTrCreateAccountResponse>> CreateAccount(MTrCreateAccountRequest request);
    Task<MTrResponse<MTrAccount>> UpdateAccountInfo(string accountUuid, MTrUpdateAccountInfoRequest request);
    Task<MTrResponse<object?>> ChangeAccountPassword(MTrChangeAccountPasswordRequest request);
    Task<MTrResponse<MTrAddAccountNoteResponse>> AddNote(MTrAddAccountNoteRequest request);
    Task<MTrResponse<MTrAddAccountTaskRequest>> AddTask(MTrAddAccountTaskRequest request);
}