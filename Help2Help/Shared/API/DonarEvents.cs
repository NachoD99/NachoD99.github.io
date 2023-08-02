using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2Help.Shared
{
    public class DonarEvents
    {
        public string name { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public int quantity { get; set; }
        public DateTime date { get; set; }
        public OrganizationData organizationData { get; set; } = new OrganizationData();
    }

    public class OrganizationData
    {
        public string name { get; set; } = string.Empty;
        public string alias { get; set; } = string.Empty;
        public string city { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string phone { get; set; } = string.Empty;
        public string address { get; set; } = string.Empty;
    }

}
