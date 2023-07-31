using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2Help.Shared.DTO
{
    public class PublicationResponseDTO
    {
        public int Id { get; set; } 
        public string Description { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int UserId { get; set; }
        public List<Image> Images { get; set; } = new List<Image>();
        public DateTime CreatedDate { get; set; }
        public LikeResponseDto Like { get; set; }  = new LikeResponseDto();
        public List<CommentResponseDto> Comments { get; set; } = new List<CommentResponseDto>();
    }
}
