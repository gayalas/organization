using Microsoft.EntityFrameworkCore;
using OrganizationApi.Domain.Models;

namespace OrganizationApi.Infraestructure.Data;

public class OrganizationDbContext : DbContext
{
    public OrganizationDbContext(DbContextOptions<OrganizationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Domains> Domains { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Domains>(entity =>
        {
            entity.ToTable("Domain", "core");

            entity.HasKey(d => d.DomainId);

            entity.Property(d => d.DomainId)
                .HasColumnName("DomainId");

            entity.Property(d => d.Name)
                .HasColumnName("Name");

            entity.Property(d => d.UId)
                .HasColumnName("UId");

            entity.Property(d => d.DisplayName)
                .HasColumnName("DisplayName");

            entity.Property(d => d.TimeZoneId)
                .HasColumnName("TimeZoneId");

            entity.Property(d => d.CultureCode)
                .HasColumnName("CultureCode");
        });
    }
}