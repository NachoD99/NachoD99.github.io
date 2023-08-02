namespace Help2Help.Client.Services.PublicationService.PublicationService
{
    public class PublicationService : IPublicationService
    {
        private readonly HttpClient http;
        public PublicationService(HttpClient http)
        {
            this.http = http;
        }
        public List<Publication> Publications { get; set; } = new List<Publication>();
        public List<PublicationResponseDTO> PublicationsDTO { get; set; } = new List<PublicationResponseDTO>();
        public string Message { get; set; } = "Cargando Publicaciones ...";
        public int CurrentPage { get; set; } = 1;
        public int PageCount { get; set; } = 0;
        public string LastSearchText { get; set; } = string.Empty;

        public event Action PublicationsChanged;

        public async Task<ServiceResponse<Publication>> GetPublication(int publicationId)
        {
            var result =
                await this.http.GetFromJsonAsync<ServiceResponse<Publication>>($"api/publication/{publicationId}");

            return result;
        }

        public async Task GetPublications(string? categoryUrl = null)
        {
            var result = categoryUrl == null ?
                await this.http.GetFromJsonAsync<ServiceResponse<List<Publication>>>("api/publication/featured") :
                await this.http.GetFromJsonAsync<ServiceResponse<List<Publication>>>($"api/publication/category/{categoryUrl}");

            if (result != null && result.Data != null) Publications = result.Data;

            CurrentPage = 1;
            PageCount = 0;

            if (Publications.Count == 0) Message = "No publications found";

            PublicationsChanged.Invoke();
        }

        public async Task<bool> GetPublicationsByUser(int usrId)
        {
            var result = await this.http.GetFromJsonAsync<ServiceResponse<List<PublicationResponseDTO>>>($"api/publication/publications-by-user/{usrId}");

            if (result != null && result.Data?.Count > 0)
            {
                PublicationsDTO = result.Data;
                return true;
            }
            else return false;

            //PublicationsChanged.Invoke();
        }

        public async Task<List<string>> GetPublicationsSearchSuggestions(string searchText)
        {
            var result = await this.http
                .GetFromJsonAsync<ServiceResponse<List<string>>>($"api/publication/searchsuggestions/{searchText}");

            return result.Data;
        }

        public async Task SearchPublications(string searchText, int page)
        {
            LastSearchText = searchText;
            var result = await this.http
                .GetFromJsonAsync<ServiceResponse<PublicationSearchResultDTO>> ($"api/publication/search/{searchText}/{page}");

            if (result != null && result.Data != null)
            {
                Publications = result.Data.Publications;
                CurrentPage = result.Data.CurrentPage;
                PageCount = result.Data.Pages;
            }

            if (Publications.Count == 0) Message = "No publications found.";
            PublicationsChanged?.Invoke();
        }

        public async Task<Publication> CreatePublication(PublicationResponseDTO request)
        {
            var response = await this.http.PostAsJsonAsync("api/publication/create", request);

            var publication = await response.Content.ReadFromJsonAsync<ServiceResponse<Publication>>();
            if (publication != null) Publications.Add(publication.Data);
            return publication.Data;
        }

        public async Task<ServiceResponse<string>> EditPublicationInfo(PublicationResponseDTO request)
        {
            var result = await this.http.PostAsJsonAsync("api/publication/edit-info", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }

        public async Task<ServiceResponse<string>> DeletePublication(PublicationResponseDTO request)
        {
            var result = await this.http.PostAsJsonAsync("api/publication/delete", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }
    }
}
