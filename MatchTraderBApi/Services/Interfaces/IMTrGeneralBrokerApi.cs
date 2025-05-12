using MatchTraderBApi.Models.Responses;
using MatchTraderBApi.Models.Responses.General;

namespace MatchTraderBApi.Services.Interfaces;

public interface IMTrGeneralBrokerApi
{
    Task<MTrResponse<MTrGetServiceInfoResponse>> GetServiceInfo();
    Task<MTrResponse<MTrGetBranchesResponse>> GetBranches();
    Task<MTrResponse<MTrGetOffersResponse>> GetOffers();
    Task<MTrResponse<MTrGetRolesResponse>> GetRoles();
    Task<MTrResponse<MTrRetrievePlatformLogsV2Response>> RetrievePlatformLogsV2();
}
