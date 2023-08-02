using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2Help.Shared
{
    public class EventReport : BaseModel
    {
        public string UserEmail { get; set; } = string.Empty;
        public int EventId { get; set; }
        public int Count { get; set; }
    }
}
