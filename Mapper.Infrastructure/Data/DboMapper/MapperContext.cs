using Mapper.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Mapper.Infrastructure.Data.DboMapper
{
    public class MapperContext : DbContext
    {
        public MapperContext(DbContextOptions<MapperContext> options) : base(options)
        { 

        }
        public DbSet<Equipament> Equipaments { get; set; }
        public DbSet<Desktop> Desktops { get; set; }
        public DbSet<Notebook> Notebooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MapperContext).Assembly);
        }

    }
}
