using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2Help.Shared
{
    public class Publication : BaseModel
    {
        public string Description { get; set; } = string.Empty;
        public int UserId { get; set; }
        public List<Image> Images { get; set; } = new List<Image>();
        public int LikesCount { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
