using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace H_EstateAgency2.Models
{
    public class Purpose
    {
        [Key]
        public int purposeID { get; set; }
        public string purposefor { get; set; }
    
    }
}
