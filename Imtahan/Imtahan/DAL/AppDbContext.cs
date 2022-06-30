using Imtahan.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan.DAL
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Setting>().HasIndex(k => k.Key).IsUnique();
            base.OnModelCreating(builder);
        }

        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Service> Services { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Setting> Settings { get; set; }
    }
}
