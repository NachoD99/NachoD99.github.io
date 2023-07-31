namespace Help2Help.Client.Services.AnalyticService
{
    public interface IAnalyticService
    {
        event Action OnChange;
        Task<Dictionary<string, double>> GetAnalyticCategoriesData();
    }
}
