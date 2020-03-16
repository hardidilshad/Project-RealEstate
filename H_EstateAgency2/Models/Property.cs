using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace H_EstateAgency2.Models
{
    public class Property
    {
        [Key]
        public int PropertyId { get; set; }
        public string PropertyType { get; set; }
        public string PropertyTitle { get; set; }

        public string PropertyCity { get; set; }
        public string PropertyAddress { get; set; }

        public int PropertyArea { get; set; }

        public double PropertyPrice { get; set; }
        public int PropertyYearOfBuilt { get; set; }
        public string PropertyComBuilt { get; set; }
        public Boolean isAvailable { get; set; }
        public DateTime PublishingDate { get; set; }
        public virtual ICollection<Picture> pictures { get; set; }
    }
}
