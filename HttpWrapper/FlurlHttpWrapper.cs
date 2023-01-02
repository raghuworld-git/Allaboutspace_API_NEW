using Flurl.Http;
using Flurl;
using Core;
using Core.Contracts.Repository;

namespace HttpWrapper
{
    public class FlurlHttpWrapper:IHttpWrapper
    {
        public async Task<TResultModel?> GetAsync<TResultModel>(string url) where TResultModel : class
        {
            if (string.IsNullOrEmpty(url.Trim()))
            {
                throw new ArgumentException("URL_EMPTY", "url");
            }

            try
            {
                IFlurlResponse result = await url.GetAsync();
               
                return await result.GetJsonAsync<TResultModel?>();

            }
            catch (FlurlHttpException ex)
            {                
                var msg = await ex.GetResponseJsonAsync();
                throw new CustomException(ex.StatusCode,msg);
            }           

        }

        public async Task<TResultModel?> GetAsyncWithQueryParams<TResultModel>(string url, object queryParams) where TResultModel : class
        {
            if (string.IsNullOrEmpty(url.Trim()))
            {
                throw new ArgumentException("URL_EMPTY", "url");
            }

            try
            {
                IFlurlResponse result = await url.SetQueryParams(queryParams).GetAsync();
                return await result.GetJsonAsync<TResultModel>();

            }
            catch (FlurlHttpException ex)
            {
                var msg = await ex.GetResponseJsonAsync();
                throw new CustomException(ex.StatusCode, msg);
            }            

        }

    }
}