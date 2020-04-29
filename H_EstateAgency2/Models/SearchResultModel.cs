using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H_EstateAgency2.Models
{
    public class SearchResultModel
    {
        public string PropertyTitle { get; set; }
        public string Ppurpose { get; set; }
        public string PropertyCity { get; set; }
        public int PropertyArea { get; set; }
        public double PropertyPrice { get; set; }
        public string picture { get; set; }
        public int PropertyId { get; set; }
    }
}
