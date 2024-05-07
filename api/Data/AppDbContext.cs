using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.obj.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Todo> Todos { get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}