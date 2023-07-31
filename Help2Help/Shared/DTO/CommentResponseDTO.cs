using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2Help.Shared.DTO
{
    public class CommentResponseDto
    {
        public string Message { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string UserProfilePicture { get; set; } = string.Empty;
        public int PublicationId { get; set; }
        public string Jwt { get; set; } = string.Empty;
    }
}
