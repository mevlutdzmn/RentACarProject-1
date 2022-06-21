using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class RentACarContext : DbContext
    {
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=MFBILGIN;Database=RentACar;Trusted_Connection=true");
            }
            public DbSet<Car> Cars  { get; set; }
            public DbSet<Brand> Brands { get; set; }
            public DbSet<Color> Colors { get; set; }
        }
    
}
