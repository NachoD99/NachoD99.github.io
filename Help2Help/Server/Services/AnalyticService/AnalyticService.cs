using Google.Analytics.Data.V1Beta;

namespace Help2Help.Server.Services.AnalyticService
{
    public class AnalyticService : IAnalyticService
    {
        private readonly DataContext context;

        public AnalyticService(DataContext context)
        {
            this.context = context;
        }

        public async Task<ServiceResponse<Dictionary<string, double>>> GetAnalyticCategoriesData()
        {
            var result = new ServiceResponse<Dictionary<string, double>>
            {
                Data = new Dictionary<string, double>()
            };
            try
            {
                /**
              * TODO(developer): Uncomment this variable and replace with your
              *  Google Analytics 4 property ID before running the sample.
              */
                string propertyId = "347678478";

                // Using a default constructor instructs the client to use the credentials
                // specified in GOOGLE_APPLICATION_CREDENTIALS environment variable.
                BetaAnalyticsDataClient client = BetaAnalyticsDataClient.Create();

                // Initialize request argument(s)
                RunReportRequest request = new RunReportRequest
                {
                    Property = "properties/" + propertyId,
                    Dimensions = { new Dimension { Name = "eventName" }, },
                    Metrics = { new Metric { Name = "eventCount" }, },
                    DateRanges = { new DateRange { StartDate = "2022-12-01", EndDate = "today" }, },
                };

                // Make the request
                var response = client.RunReport(request);

                foreach (Row row in response.Rows)
                {
                    if (row.DimensionValues[0].Value.Contains("clickEn"))
                    {
                        row.DimensionValues[0].Value = row.DimensionValues[0].Value.Replace("clickEn", "");
                        result.Data.Add(row.DimensionValues[0].Value, double.Parse(row.MetricValues[0].Value));
                    }
                    if (row.DimensionValues[0].Value.Contains("ClickEn"))
                    {
                        row.DimensionValues[0].Value = row.DimensionValues[0].Value.Replace("ClickEn", "");
                        result.Data.Add(row.DimensionValues[0].Value, double.Parse(row.MetricValues[0].Value));
                    }
                }
                result.Data.OrderBy(x => x.Value);
                return result;
            }
            catch (Exception ex)
            {
                var dfdfg = ex.Message;
                throw;
            }

        }
    }
}
