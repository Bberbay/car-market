using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Context;

public class CarMarketContext : DbContext // Ef object
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Host=localhost;Database=car-market;Username=postgres;Password=3naexlzzx";
        optionsBuilder.UseNpgsql(connectionString);
    }

    public DbSet<Cars> Cars { get; set; }
}