using Microsoft.EntityFrameworkCore;
using RoomsWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomsWebApi.Services
{
    public class RoomsDbContext : DbContext
    {
        public RoomsDbContext(DbContextOptions<RoomsDbContext> options)
            :base(options)
        {

        }

        public virtual DbSet<Rooms> Rooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            modelBuilder.Entity<Rooms>()
                .HasKey(a => a.Id);
            */
        }
    }
}
