using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Todo> Todos { get; set; }
        public DbSet<Team> Teams { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name="Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {

                    Name="User",
                    NormalizedName = "USER"
                }
            };
            builder.Entity<IdentityRole>().HasData(roles);

            List<Team> teams = new List<Team>
            {
                new Team{
                    Id = 1,
                    Name = "Individual"
                },
                new Team
                {
                    Id = 2,
                    Name = "Development Team",
                },
                new Team
                {
                    Id=3,
                    Name = "Marketing Team",
                },
                new Team
                {
                    Id=4,
                    Name = "HR Team",
                }
            };
            builder.Entity<Team>().HasData(teams);


            // List<Todo> todos = new List<Todo>
            // {
            //     new Todo
            //     {
            //         Title = "Implement authentication feature",
            //         Description = "Implement user authentication and authorization feature using JWT tokens",

            //         TeamId = 1,
            //         CreatedDate = DateTime.Now,
            //         IsCompleted = false,

            //     },
            // };
            // builder.Entity<Todo>().HasData(todos);
        }
    }
}