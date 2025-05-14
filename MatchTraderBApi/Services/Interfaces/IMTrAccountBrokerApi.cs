using MatchTraderBApi.Enums;
using MatchTraderBApi.Enums.Account;
using MatchTraderBApi.Enums.SortingFields;
using MatchTraderBApi.Models.Dtos.Account;
using MatchTraderBApi.Models.Requests.Accounts;
using MatchTraderBApi.Models.Responses;
using MatchTraderBApi.Models.Responses.Account;

namespace MatchTraderBApi.Services.Interfaces;

public interface IMTrAccountBrokerApi
{
    Task<MTrResponse<MTrGetAccountsResponse>> GetAccounts(string? query, int? page, int? size, DateTimeOffset? from, DateTimeOffset? to, MTrAccountType? accountType, MTrAccountSortingField? sortField, MTrSortingOrder? sortingOrder, CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrAccount>> GetAccountByEmail(string email, CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrAccount>> GetAccountByUuid(string accountUuid, CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrGetAccountTimelineEventsResponse>> GetAccountTimelineEvents(string accountUuid, MTrAccountTimelineEventType? eventType, DateTimeOffset? from, DateTimeOffset? to, MTrBasicSortingField? sortField, MTrSortingOrder? sortOrder, CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrCreateAccountResponse>> CreateAccount(MTrCreateAccountRequest request, CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrAccount>> UpdateAccountInfo(string accountUuid, MTrUpdateAccountInfoRequest request, CancellationToken cancellationToken = default);
    Task<MTrResponse<object?>> ChangeAccountPassword(string accountUuid, string newPassword, CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrAddAccountNoteResponse>> AddNote(string accountUuid, string content, MTrNoteType type, CancellationToken cancellationToken = default);
    Task<MTrResponse<MTrAddAccountTaskResponse>> AddTask(string accountUuid, MTrTaskType type, DateTimeOffset startDate, MTrTaskStatus status, string accountManagerUuid, string comment, CancellationToken cancellationToken = default);
}