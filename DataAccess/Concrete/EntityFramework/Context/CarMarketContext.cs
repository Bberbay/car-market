using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Context;

public class CarMarketContext : DbContext // Ef object
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
        var connectionString = "Host=localhost; port=5432;Database=car-marketv2;Username=postgres;Password=admin ";
        optionsBuilder.UseNpgsql(connectionString);
    }
    public DbSet<Cars> Cars { get; set; }
    public DbSet<Users> Users { get; set; }
}