using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EShoppingZone.Models;

namespace EShoppingZone.Data
{
    public class EShoppingZoneContext : DbContext
    {
        public EShoppingZoneContext (DbContextOptions<EShoppingZoneContext> options)
            : base(options)
        {
        }

        public DbSet<EShoppingZone.Models.Product>? Product { get; set; }

        public DbSet<EShoppingZone.Models.User>? User { get; set; }
    }
}
