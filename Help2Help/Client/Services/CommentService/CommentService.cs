
using Blazored.LocalStorage;

namespace Help2Help.Client.Services.CommentService
{
    public class CommentService : ICommentService
    {
        private readonly HttpClient http;
        private readonly IPublicationService publicationService;
        private readonly ILocalStorageService localStorage;

        public event Action OnChange;
        public CommentService(HttpClient http, IPublicationService publicationService, ILocalStorageService localStorage)
        {
            this.http = http;
            this.publicationService = publicationService;
            this.localStorage = localStorage;
        }

        public async Task<List<CommentResponseDto>> AddComment(int publicationId, string message)
        {
            string token = await this.localStorage.GetItemAsync<string>("authToken");
            var request = new CommentResponseDto() 
            { 
                PublicationId = publicationId, 
                Message = message,
                Jwt = token != null ? token : string.Empty 
            };
            var response = await this.http.PostAsJsonAsync("api/comment", request);

            var publication = await response.Content.ReadFromJsonAsync<ServiceResponse<CommentResponseDto>>();

            var pub = this.publicationService.PublicationsDTO.FirstOrDefault(x => x.Id == publicationId);
            pub.Comments.Add(publication?.Data);

            return pub.Comments;
        }

    }
}
