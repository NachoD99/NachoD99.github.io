namespace Help2Help.Client.Services.MapService
{
    public interface IMapService
    {
        event Action OnChange;
        Task<List<MapResponseDTO>> GetMapMarkers();
        Task<List<ProvinceResponseDTO>> GetProvinces();
        Task<List<CityResponseDTO>> GetCities(string provinceId);
    }
}
