using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2Help.Shared
{
    public class Image : BaseModel
    {
        public string FileName { get; set; } = string.Empty;
        public long FileSize { get; set; }
        public string FileContent { get; set; } = string.Empty;
        public string Guid { get; set; } = string.Empty;
        public bool OnServer { get; set; } = false;
    }
}
