using Microsoft.EntityFrameworkCore;

namespace Demo.EntityFramework.ComplexQuery.FromSql.Api.EntityFramework;

public class DemoContext : DbContext
{
    public DemoContext(DbContextOptions options) : base(options)
    {
    }
}