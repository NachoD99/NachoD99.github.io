using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2Help.Shared
{
    public class EventCategory : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public string FatherCategory { get; set; } = string.Empty;
        public string? SubCategory { get; set; } = string.Empty;
    }
}
