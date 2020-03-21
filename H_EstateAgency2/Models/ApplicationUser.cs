using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H_EstateAgency2.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string City { get; set; }
    }
}
