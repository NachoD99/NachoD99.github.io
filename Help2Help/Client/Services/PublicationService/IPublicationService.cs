namespace Help2Help.Client.Services.PublicationService.PublicationService
{
    public interface IPublicationService
    {
        event Action PublicationsChanged;
        List<Publication> Publications { get; set; }
        List<PublicationResponseDTO> PublicationsDTO { get; set; }
        string Message { get; set; }
        int CurrentPage { get; set; }
        int PageCount { get; set; }
        string LastSearchText { get; set; }

        Task GetPublications(string? categoryUrl = null);
        Task<bool> GetPublicationsByUser(int usrId);
        Task<ServiceResponse<Publication>> GetPublication(int publicationId);
        Task SearchPublications(string searchText, int page);
        Task<List<string>> GetPublicationsSearchSuggestions(string searchText);
        Task<Publication> CreatePublication(PublicationResponseDTO request);
        Task<ServiceResponse<string>> EditPublicationInfo(PublicationResponseDTO request);
        Task<ServiceResponse<string>> DeletePublication(PublicationResponseDTO request);
    }
}

/*
 La generación de los servicios en el cliente sirve para almacenar en un solo lado la información
requerida en vez de tenerla almacenada en cada componente que se genera.
Esto nos brinda una mejor arquitectura y favorece a reducir los tiempos de procesamiento.
 */
