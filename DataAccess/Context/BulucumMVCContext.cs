using DataAccess.Mapping;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class BulucumMVCContext : DbContext
    {
        //public BulucumMVCContext(DbContextOptions<BulucumMVCContext> dbContextOptions) : base(dbContextOptions) { }

        public DbSet<Brand> Brands { get; set; }=null!;
        public DbSet<Seeker> Seekers { get; set; } = null!;
        public DbSet<Finder> Finders { get; set; } = null!;
        public DbSet<VehicleType> VehicleTypes { get; set; } = null!;
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<Proclamation> Proclamations { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SAMET\\SQLEXPRESS;database=AskBulucumMVC;trusted_connection=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BrandMap());
            modelBuilder.ApplyConfiguration(new SeekerMap());
            modelBuilder.ApplyConfiguration(new FinderMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new VehicleTypeMap());
            modelBuilder.ApplyConfiguration(new CityMap());
            modelBuilder.ApplyConfiguration(new ProclamationMap());
            modelBuilder.ApplyConfiguration(new BrandVehicleTypeMap());
        }
    }
}
