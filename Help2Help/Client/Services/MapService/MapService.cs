using Blazored.LocalStorage;

namespace Help2Help.Client.Services.MapService
{
    public class MapService : IMapService
    {
        private readonly HttpClient http;
        public event Action OnChange;
        public MapService( HttpClient http)
        {
            this.http = http;
        }

        public async Task<List<MapResponseDTO>> GetMapMarkers()
        {
            var response = await this.http.PostAsJsonAsync("api/map/markers", 1);

            var markers = await response.Content.ReadFromJsonAsync<ServiceResponse<List<MapResponseDTO>>>();
            return markers.Data;
        }

        public async Task<List<ProvinceResponseDTO>> GetProvinces()
        {
            var result = await http.GetFromJsonAsync<ServiceResponse<List<ProvinceResponseDTO>>>("api/map/provinces");
            return result.Data;
        }

        public async Task<List<CityResponseDTO>> GetCities(string provinceId)
        {
            var result = await http.GetFromJsonAsync<ServiceResponse<List<CityResponseDTO>>>($"api/map/cities/{provinceId}");
            return result.Data;
        }
    }
}
