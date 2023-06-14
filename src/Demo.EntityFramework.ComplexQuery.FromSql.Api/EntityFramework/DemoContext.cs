using Demo.EntityFramework.ComplexQuery.FromSql.Api.Model;
using Microsoft.EntityFrameworkCore;

namespace Demo.EntityFramework.ComplexQuery.FromSql.Api.EntityFramework;

public class DemoContext : DbContext
{
    public DbSet<QuerySalesCostumer> QuerySalesCostumers { get; set; } = null!;

    public DemoContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<QuerySalesCostumer>(builder => 
        {
            builder.HasNoKey();
        });
    }
}