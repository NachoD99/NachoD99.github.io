namespace Help2Help.Server.Services.PublicationService
{
    public interface IPublicationService
    {
        Task<ServiceResponse<Publication>> CreatePublication(PublicationResponseDTO request);
        Task<ServiceResponse<List<PublicationResponseDTO>>> GetPublicationsByUser(int usrId, string currentUserMail);
        Task<ServiceResponse<string>> EditPublicationInfo(PublicationResponseDTO request);
        Task<ServiceResponse<string>> DeletePublication(PublicationResponseDTO request);
        //Task<ServiceResponse<List<Publication>>> GetPublicationsAsync();
        //Task<ServiceResponse<Publication>> GetPublicationAsync(int publicationId);
        //Task<ServiceResponse<List<Publication>>> GetPublicationsByCategory(string categoryUrl);
        ////Se puede modificar para la búsqueda de personas
        //Task<ServiceResponse<PublicationSearchResultDTO>> SearchPublications(string searchText, int page);
        //Task<ServiceResponse<List<string>>> SearchPublicationsSuggestions(string searchText);
        //Task<ServiceResponse<List<Publication>>> GetFeaturedPublications();
    }
}
