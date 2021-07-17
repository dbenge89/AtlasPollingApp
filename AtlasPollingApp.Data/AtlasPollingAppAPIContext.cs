using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AtlasPollingApp.API.Models;

namespace AtlasPollingApp.API.Data
{
    public class AtlasPollingAppAPIContext : DbContext
    {
        public AtlasPollingAppAPIContext (DbContextOptions<AtlasPollingAppAPIContext> options)
            : base(options)
        {
        
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Poll> Polls { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AtlasPollingAppAPIContext>()
                .HasKey(s => new { s.Users });
            base.OnModelCreating(modelBuilder);
        }
    }
}
