
using Blazored.LocalStorage;

namespace Help2Help.Client.Services.DocumentService
{
    public class DocumentService : IDocumentService
    {
        private readonly HttpClient http;
        private readonly IPublicationService publicationService;
        private readonly ILocalStorageService localStorage;

        public event Action OnChange;
        public DocumentService(HttpClient http, IPublicationService publicationService, ILocalStorageService localStorage)
        {
            this.http = http;
            this.publicationService = publicationService;
            this.localStorage = localStorage;
        }

        public async Task<DocumentResponseDTO> SaveCertificate(DocumentRequestDTO certificate, DocumentRequestDTO swornDeclaration)
        {
            string token = await this.localStorage.GetItemAsync<string>("authToken");
            certificate.Jwt = token != null ? token : string.Empty;
            certificate.FileNameSwornDeclaration = swornDeclaration.FileName;
            certificate.FileContentSwornDeclaration = swornDeclaration.FileContent;
            var response = await this.http.PostAsJsonAsync("api/document/upload", certificate);

            var verification = await response.Content.ReadFromJsonAsync<ServiceResponse<DocumentResponseDTO>>();

            return verification.Data;
        }

        public async Task<List<GetCertificatesResponseDTO>> GetCertificates()
        {
            var result =
                await this.http.GetFromJsonAsync<ServiceResponse<List<GetCertificatesResponseDTO>>>("api/document/get-certificates");

            return result.Data;

        }

        public async Task<GetCertificatesResponseDTO> DownloadTutorialGuide()
        {
            var result =
                await this.http.GetFromJsonAsync<ServiceResponse<GetCertificatesResponseDTO>>("api/document/get-tutorial-guide");

            return result.Data;

        }

        public async Task<GetCertificatesResponseDTO> DownloadSwornDeclaration()
        {
            var result =
                await this.http.GetFromJsonAsync<ServiceResponse<GetCertificatesResponseDTO>>("api/document/get-sworn-declaration");

            return result.Data;

        }
    }
}
