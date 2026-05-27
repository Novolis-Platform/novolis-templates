using Microsoft.EntityFrameworkCore;
using Novolis.Templates.Microservice.Data.Entities;

namespace Novolis.Templates.Microservice.Data;

public sealed class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<CompanyEntity> Companies => Set<CompanyEntity>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CompanyEntity>(entity =>
        {
            entity.ToTable("Companies");
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).HasMaxLength(256).IsRequired();
        });
    }
}
