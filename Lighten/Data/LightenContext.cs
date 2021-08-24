using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lighten.Models;

namespace Lighten.Data
{
    public class LightenContext : DbContext
    {
        public LightenContext (DbContextOptions<LightenContext> options)
            : base(options)
        {
        }
        public DbSet<Products> Products { get; set; }
        public DbSet<YourProducts> YourProducts { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Authenticate> Authenticate { get; set; }
    }
}
