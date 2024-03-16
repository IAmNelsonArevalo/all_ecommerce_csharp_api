using EcommerceApiCSharp.Models;
using Microsoft.EntityFrameworkCore;

public class AllEcommerceContext: DbContext
{
    public AllEcommerceContext(DbContextOptions<AllEcommerceContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Status> Status { get; set; }
}