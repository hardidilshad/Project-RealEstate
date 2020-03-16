using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace H_EstateAgency2.Models
{
    public class Picture
    {

        [Key]
        public int PicId { get; set; }

        public byte[] photo { get; set; }

        public string PicName { get; set; }

        public int? PropertyId { get; set; }
    }
}
