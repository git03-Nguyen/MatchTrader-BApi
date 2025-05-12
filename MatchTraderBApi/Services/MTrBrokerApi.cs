using MatchTraderBApi.Constants.RestEndpoints;
using MatchTraderBApi.Enums;
using MatchTraderBApi.Exceptions;
using MatchTraderBApi.Helpers;
using MatchTraderBApi.Models.Responses;
using MatchTraderBApi.Models.Responses.General;
using MatchTraderBApi.Options;
using Microsoft.Extensions.Options;

namespace MatchTraderBApi.Services;

public class MTrBrokerApi : IMTrBrokerApi
{
    public HttpClient HttpClient { get; set; }
    private readonly MTrSettingsOptions _settings;
    public MTrBrokerApi
    (
        IOptions<MTrSettingsOptions> settings
    )
    {
        _settings = settings.Value;
    }
    #region General

    public async Task<MTrResponse<MTrGetServiceInfoResponse>> GetServiceInfo()
    {
        var response = new MTrResponse<MTrGetServiceInfoResponse>();
        try
        {
            var mtrResponse = await HttpClientHelper.SendAuthorizedAsync<object, MTrGetServiceInfoResponse>(
                HttpClient, 
                _settings, 
                HttpMethod.Get, 
                GeneralEndpoints.ServiceInfo(), 
                null, 
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

    public Task<MTrResponse<MTrGetBranchesResponse>> GetBranches()
    {
        throw new NotImplementedException();
    }

    public Task<MTrResponse<MTrGetOffersResponse>> GetOffers()
    {
        throw new NotImplementedException();
    }

    public Task<MTrResponse<MTrGetRolesResponse>> GetRoles()
    {
        throw new NotImplementedException();
    }

    public Task<MTrResponse<MTrRetrievePlatformLogsV2Response>> RetrievePlatformLogsV2()
    {
        throw new NotImplementedException();
    }

    #endregion
}