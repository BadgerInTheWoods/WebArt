using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using WebArt.Model.Entities;

namespace WebArt.Data
{
    public class WebArtDbContext : DbContext
    {
        public WebArtDbContext(DbContextOptions<WebArtDbContext> options) : base(options)
        {
        }

        public DbSet<Painting> Paintings { get; set; }
        public DbSet<User> Users { get; set; }
    }
    public class WebArtDbContextFactory : IDesignTimeDbContextFactory<WebArtDbContext>
    {
        public WebArtDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
            .Build();

            var optionsBuilder = new DbContextOptionsBuilder<WebArtDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseNpgsql(connectionString);

            return new WebArtDbContext(optionsBuilder.Options);
        }
    }
}

