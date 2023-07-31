namespace Help2Help.Client.Services.AnalyticService
{
    public class AnalyticService : IAnalyticService
    {
        private readonly HttpClient http;
        public event Action OnChange;
        public AnalyticService( HttpClient http)
        {
            this.http = http;
        }

    public async Task<Dictionary<string, double>> GetAnalyticCategoriesData()
    {
        var result = await this.http.GetFromJsonAsync<ServiceResponse<Dictionary<string, double>>>("api/analytic/get-analytics");

        return result.Data;
    }
}
}
