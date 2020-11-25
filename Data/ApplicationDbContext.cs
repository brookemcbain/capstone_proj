using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Capstone.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Neighbor> Neighbors { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Post> Posts { get; set; }
  


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole
                    {
                   
                        Name = "Neighbor",
                        NormalizedName = "NEIGHBOR"
                    },
                    new IdentityRole
                    {
                      
                        Name = "Employee",
                        NormalizedName = "EMPLOYEE"
                    }
                  );
        }

    }
}
