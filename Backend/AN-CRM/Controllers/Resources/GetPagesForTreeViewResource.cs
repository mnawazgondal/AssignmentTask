using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AN_CRM.Controllers.Resources
{
    public class GetPagesForTreeViewResource
    {
        public string  Text { get; set; }
        public int Value { get; set; }
        public bool Collapsed { get; set; }
        public bool Checked { get; set; }
        public List<GetPagesForTreeViewResource> Children { get; set; }
    }

    public class GetPagesForTreeDbResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Parent { get; set; }
    }
}
