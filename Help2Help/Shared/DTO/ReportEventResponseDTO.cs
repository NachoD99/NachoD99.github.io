using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2Help.Shared.DTO
{
    public class ReportEventResponseDto
    {
        public int EventId { get; set; }
        public string Jwt { get; set; } = string.Empty;
    }
}
