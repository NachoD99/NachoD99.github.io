using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2Help.Shared.DTO
{
    public class DocumentResponseDTO
    {
        public string Message { get; set; } = string.Empty;
        public bool IsVerificationInProgress { get; set; } = false;
    }
}
