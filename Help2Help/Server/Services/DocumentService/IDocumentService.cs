namespace Help2Help.Server.Services.DocumentService
{
    public interface IDocumentService
    {
        Task<ServiceResponse<DocumentResponseDTO>> UploadDocument(DocumentRequestDTO certificate, string userEmail);
        Task<ServiceResponse<List<GetCertificatesResponseDTO>>> GetCertificates();
        Task<ServiceResponse<GetCertificatesResponseDTO>> DownloadTutorialGuide();
        Task<ServiceResponse<GetCertificatesResponseDTO>> DownloadSwornDeclaration();
    }
}
