using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2Help.Shared.DTO
{
    public class DocumentRequestDTO
    {
        public string FileName { get; set; } = string.Empty;
        public long FileSize { get; set; }
        public string FileContent { get; set; } = string.Empty;
        public string Guid { get; set; } = string.Empty;
        public bool OnServer { get; set; } = false;
        public string Jwt { get; set; } = string.Empty;
        public string FileNameSwornDeclaration { get; set; } = string.Empty;
        public string FileContentSwornDeclaration { get; set; } = string.Empty;
    }
}
