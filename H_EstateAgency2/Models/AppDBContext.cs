using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using H_EstateAgency2.Models;



namespace H_EstateAgency2.Models
{
    public class AppDBContext : IdentityDbContext
    {


        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<PType> PTypes { get; set; }
        public DbSet<PCity> PCitys { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Property> Properties { get; set; }
    }
}
