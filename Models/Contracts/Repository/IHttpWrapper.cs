namespace Core.Contracts.Repository
{
    public interface IHttpWrapper
    {
        Task<TResultModel?> GetAsync<TResultModel>(string url) where TResultModel : class;
        Task<TResultModel?> GetAsyncWithQueryParams<TResultModel>(string url, object queryParams) where TResultModel : class;
    }
}
