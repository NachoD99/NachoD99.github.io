namespace Help2Help.Server.Services.MapService
{
    public interface IMapService
    {
        Task<ServiceResponse<List<MapResponseDTO>>> GetMapMarkers();
        Task SaveProvincesInDb();
        Task SaveCitiesInDb();
        Task<ServiceResponse<List<ProvinceResponseDTO>>> GetProvinces();
        Task<ServiceResponse<List<CityResponseDTO>>> GetCities(string provinceId);
    }
}
