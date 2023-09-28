using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.TestModels.Northwind;

namespace MongoDB.EntityFrameworkCore.TestSuite.Utilities;

public class NorthwindMongoDbContext : NorthwindContext
{
    public NorthwindMongoDbContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasKey(p => p.ProductID);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        base.ConfigureConventions(configurationBuilder);
    }
}
