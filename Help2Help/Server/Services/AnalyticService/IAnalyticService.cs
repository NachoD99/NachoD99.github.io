namespace Help2Help.Server.Services.AnalyticService
{
    public interface IAnalyticService
    {
        Task<ServiceResponse<Dictionary<string, double>>> GetAnalyticCategoriesData();
    }
}
