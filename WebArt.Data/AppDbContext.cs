using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebArt.Model.Entities;

namespace WebArt.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Painting> Paintings { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

