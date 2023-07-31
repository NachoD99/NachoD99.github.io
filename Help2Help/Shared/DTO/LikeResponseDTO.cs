using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2Help.Shared.DTO
{
    public class LikeResponseDto
    {
        public int PublicationId { get; set; }
        public bool Liked { get; set; }
        public int Count { get; set; }
        public string Jwt { get; set; } = string.Empty;
    }
}
