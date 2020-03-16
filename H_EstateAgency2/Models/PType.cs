using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace H_EstateAgency2.Models
{
    public class PType
    {

        [Key]
        public int PTypeId { get; set; }

        public string PTypeName { get; set; }


        public int PTypeNo { get; set; }
    }
}
