using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2Help.Shared
{
    public class Like : BaseModel
    {
        public string UserEmail { get; set; } = string.Empty;
        public int PublicationId { get; set; }
        public int Count { get; set; }
        public bool Liked { get; set; }
    }
}
