using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2Help.Shared
{
    public class Province : BaseModel
    {
        public string ProvinceId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}
