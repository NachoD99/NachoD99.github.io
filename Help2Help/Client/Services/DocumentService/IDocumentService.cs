namespace Help2Help.Client.Services.DocumentService
{
    public interface IDocumentService
    {
        event Action OnChange;
        Task<DocumentResponseDTO> SaveCertificate(DocumentRequestDTO certificate, DocumentRequestDTO swornDeclaration);
        Task<List<GetCertificatesResponseDTO>> GetCertificates();
        Task<GetCertificatesResponseDTO> DownloadTutorialGuide();
        Task<GetCertificatesResponseDTO> DownloadSwornDeclaration();
    }
}
