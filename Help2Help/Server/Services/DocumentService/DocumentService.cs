using Help2Help.Shared;

namespace Help2Help.Server.Services.DocumentService
{
    public class DocumentService : IDocumentService
    {
        private readonly DataContext context;
        private readonly INotificationService notificationService;

        public DocumentService(DataContext context, INotificationService notificationService)
        {
            this.context = context;
            this.notificationService = notificationService;
        }

        public async Task<ServiceResponse<DocumentResponseDTO>> UploadDocument(DocumentRequestDTO certificate, string userEmail)
        {
            if (certificate != null)
            {
                var guid = Guid.NewGuid().ToString().Substring(0, 18);
                var certificateToDb = new Document()
                {
                    FileContent = certificate.FileContent,
                    CreatedDate = DateTime.Now,
                    Guid = certificate.Guid,
                    OnServer = true,
                    UserEmail = userEmail,
                    TransactionID = guid
                };

                var certificatesFromDb = this.context.Documents.Where(x => x.FileName == certificate.FileName).ToList();

                if (certificatesFromDb.Count > 0)
                {
                    if (certificatesFromDb.Count == 1) certificateToDb.FileName =
                             string.Concat("Certificado_", certificate.FileName, "_", (certificatesFromDb.Count).ToString());
                    if (certificatesFromDb.Count > 1) certificateToDb.FileName =
                             string.Concat("Certificado_", certificate.FileName, "_", (certificatesFromDb.Count + 1).ToString());
                }
                else certificateToDb.FileName = string.Concat("Certificado_", certificate.FileName);

                this.context.Documents.Add(certificateToDb);
                await this.context.SaveChangesAsync();

                if (certificate.FileNameSwornDeclaration != string.Empty)
                {
                    var swornDeclaration = new Document()
                    {
                        FileContent = certificate.FileContentSwornDeclaration,
                        CreatedDate = DateTime.Now,
                        Guid = certificate.Guid,
                        OnServer = true,
                        UserEmail = userEmail,
                        TransactionID = guid
                    };

                    var swornDeclarationFromDb = this.context.Documents.Where(x => x.FileName == certificate.FileNameSwornDeclaration).ToList();

                    if (swornDeclarationFromDb.Count > 0)
                    {
                        if (swornDeclarationFromDb.Count == 1) swornDeclaration.FileName =
                                 string.Concat("DeclaracionJurada_", swornDeclaration.FileName, "_", (swornDeclarationFromDb.Count).ToString());
                        if (swornDeclarationFromDb.Count > 1) swornDeclaration.FileName =
                                 string.Concat("DeclaracionJurada_", swornDeclaration.FileName, "_", (swornDeclarationFromDb.Count + 1).ToString());
                    }
                    else swornDeclaration.FileName = string.Concat("DeclaracionJurada_", certificate.FileNameSwornDeclaration);

                    this.context.Documents.Add(swornDeclaration);
                    await this.context.SaveChangesAsync();
                }

                await this.notificationService.AddNotification(null, null, userEmail, NotificationTypes.RequestVerification, null);

                return new ServiceResponse<DocumentResponseDTO>
                {
                    Data = new DocumentResponseDTO()
                    {
                        Message = "Documento subido correctamente. En breve un admistrador estará revisando su caso " +
                                  "para aprovar su verificación.",
                        IsVerificationInProgress = true
                    },
                    Success = true
                };
            }
            else
            {
                return new ServiceResponse<DocumentResponseDTO>
                {
                    Data = new DocumentResponseDTO()
                    {
                        Message = "Ha ocurrido un error",
                        IsVerificationInProgress = false
                    },
                    Success = false
                };
            }

        }

        public async Task<ServiceResponse<List<GetCertificatesResponseDTO>>> GetCertificates()
        {
            var response = new ServiceResponse<List<GetCertificatesResponseDTO>>
            {
                Data = new List<GetCertificatesResponseDTO>()
            };

            var certificates = this.context.Documents
                .Where(x => x.DeletedDate == null && x.FileName != "Declaracion_Jurada" && x.FileName != "Guia_Tutorial")
                .OrderBy(x => x.CreatedDate)
                .ToList();

            foreach (var certificate in certificates)
            {
                var user = await this.context.Users.Where(x => x.Email == certificate.UserEmail).FirstOrDefaultAsync();

                var certificateToMap = new GetCertificatesResponseDTO()
                {
                    Id = certificate.Id,
                    CreatedDate = certificate.CreatedDate,
                    UserId = user.Id,
                    UserName = string.Concat(user.FirstName, " ", user.LastName),
                    TransactionID = certificate.TransactionID
                };

                if (certificate.FileName.Split("_").First() == "Certificado")
                {
                    certificateToMap.FileContent = certificate.FileContent;
                    certificateToMap.FileName = certificate.FileName.Split("_").Last();
                }
                else if (certificate.FileName.Split("_").First() == "DeclaracionJurada")
                {
                    certificateToMap.FileContentSwornDeclaration = certificate.FileContent;
                    certificateToMap.FileNameSwornDeclaration = certificate.FileName.Split("_").Last();
                }
                if(response.Data.Any(x => x.TransactionID == certificate.TransactionID))
                {
                    var updateAttributes = response.Data.FirstOrDefault(x => x.TransactionID == certificate.TransactionID);

                    if (updateAttributes.FileName == string.Empty)
                    {
                        updateAttributes.FileName = certificateToMap.FileName;
                        updateAttributes.FileContent = certificateToMap.FileContent;
                    }

                    if (updateAttributes.FileNameSwornDeclaration == string.Empty)
                    {
                        updateAttributes.FileNameSwornDeclaration = certificateToMap.FileNameSwornDeclaration;
                        updateAttributes.FileContentSwornDeclaration = certificateToMap.FileContentSwornDeclaration;
                    }

                }
                else response.Data.Add(certificateToMap);
            }

            return response;
        }

        public async Task<ServiceResponse<GetCertificatesResponseDTO>> DownloadTutorialGuide()
        {
            var response = new ServiceResponse<GetCertificatesResponseDTO>();

            var certificate = this.context.Documents.Where(x => x.FileName == "Guia_Tutorial").FirstOrDefault();

            if (certificate != null)
            {
                response.Data = new GetCertificatesResponseDTO()
                {
                    FileContent = certificate.FileContent,
                    FileName = certificate.FileName
                };
            }

            return response;
        }

        public async Task<ServiceResponse<GetCertificatesResponseDTO>> DownloadSwornDeclaration()
        {
            var response = new ServiceResponse<GetCertificatesResponseDTO>();

            var certificate = this.context.Documents.Where(x => x.FileName == "Declaracion_Jurada").FirstOrDefault();

            if (certificate != null)
            {
                response.Data = new GetCertificatesResponseDTO()
                {
                    FileContent = certificate.FileContent,
                    FileName = certificate.FileName
                };
            }

            return response;
        }
    }
}
