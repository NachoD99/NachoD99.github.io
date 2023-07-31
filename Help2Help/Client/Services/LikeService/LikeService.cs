
using Blazored.LocalStorage;

namespace Help2Help.Client.Services.LikeService
{
    public class LikeService : ILikeService
    {
        private readonly HttpClient http;
        private readonly IPublicationService publicationService;
        private readonly ILocalStorageService localStorage;

        public event Action OnChange;
        public LikeService(HttpClient http, IPublicationService publicationService, ILocalStorageService localStorage)
        {
            this.http = http;
            this.publicationService = publicationService;
            this.localStorage = localStorage;
        }

        public async Task<ServiceResponse<LikeResponseDto>> CheckLike(int publicationId)
        {
            string token = await this.localStorage.GetItemAsync<string>("authToken");
            var request = new LikeResponseDto() { PublicationId = publicationId, Jwt = token != null ? token : string.Empty };
            var response = await this.http.PostAsJsonAsync("api/like", request);

            var publication = await response.Content.ReadFromJsonAsync<ServiceResponse<LikeResponseDto>>();

            var pub = this.publicationService.PublicationsDTO.FirstOrDefault(x => x.Id == publicationId);
            pub.Like = publication?.Data;

            return publication;
        }

    }
}
