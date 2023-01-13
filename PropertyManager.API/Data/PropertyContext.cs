using Microsoft.EntityFrameworkCore;
using PropertyManager.API.Models;

namespace PropertyManager.API.Data
{
    public class PropertyContext: DbContext
    {
        public PropertyContext(DbContextOptions<PropertyContext> options) : base(options)
        {
            
        }

        

        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyType> PropertyTypes { get; set; }
        public DbSet<PropertyStatus> PropertyStatuses { get; set; }
        public DbSet<PropertyStyle> PropertyStyles { get; set; }
        public DbSet<PropertyCondition> PropertyConditions { get; set; }
        public DbSet<PropertyHeating> PropertyHeatings { get; set; }
        public DbSet<PropertyCooling> PropertyCoolings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Property>().ToTable("Property");
            modelBuilder.Entity<PropertyType>().ToTable("PropertyType");
            modelBuilder.Entity<PropertyStatus>().ToTable("PropertyStatus");
            modelBuilder.Entity<PropertyStyle>().ToTable("PropertyStyle");
            modelBuilder.Entity<PropertyCondition>().ToTable("PropertyCondition");
            modelBuilder.Entity<PropertyHeating>().ToTable("PropertyHeating");
            modelBuilder.Entity<PropertyCooling>().ToTable("PropertyCooling");
            
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=PropertyManager;Trusted_Connection=True;MultipleActiveResultSets=true");
        }



    }
}
