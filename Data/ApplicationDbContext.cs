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
        public DbSet<LostAndFound> LostAndFound { get; set; }



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
                        Name = "Lower East Side",
                        NormalizedName = "LOWER EAST SIDE"
                    },
                    new IdentityRole
                    {

                        Name = "River West",
                        NormalizedName = "RIVER WEST"
                    },
                    new IdentityRole
                    {

                        Name = "Downtown",
                        NormalizedName = "DOWNTOWN"
                    },
                    new IdentityRole
                    {

                        Name = "Brewer's Hill",
                        NormalizedName = "BREWER'S HILL"
                    },
                    new IdentityRole
                    {

                        Name = "Franklin Heights",
                        NormalizedName = "FRANKLIN HEIGHTS"
                    },
                    new IdentityRole
                    {

                        Name = "Third Ward",
                        NormalizedName = "THIRD WARD"
                    },
                    new IdentityRole
                    {

                        Name = "Walker's Point",
                        NormalizedName = "WALKER'S POINT"
                    },
                    new IdentityRole
                    {

                        Name = "Story Hill",
                        NormalizedName = "STORY HILL"
                    },
                    new IdentityRole
                    {

                        Name = "Washington Heights",
                        NormalizedName = "WASHINGTON HEIGHTS"
                    },
                    new IdentityRole
                    {

                        Name = "Bay View",
                        NormalizedName = "BAY VIEW"
                    }

                  );
        }

    }
}
