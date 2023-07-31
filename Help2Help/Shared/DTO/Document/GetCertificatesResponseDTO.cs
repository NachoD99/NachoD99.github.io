using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2Help.Shared.DTO
{
    public class GetCertificatesResponseDTO
    {
        public int Id { get; set; }
        public string FileName { get; set; } = string.Empty;
        public string FileContent { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string FileNameSwornDeclaration { get; set; } = string.Empty;
        public string FileContentSwornDeclaration { get; set; } = string.Empty;
        public string TransactionID { get; set; } = string.Empty;
    }
}
