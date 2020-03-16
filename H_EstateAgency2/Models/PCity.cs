using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace H_EstateAgency2.Models
{
    public class PCity
    {
        [Key]
        public int PCityId { get; set; }
    
        public string PCityName { get; set; }


        public int PCityNo { get; set; }
    }
}
