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
            entity.ToTable("domain", "core");

            entity.HasKey(d => d.DomainId);

            entity.Property(d => d.DomainId)
                .HasColumnName("domainid");

            entity.Property(d => d.Name)
                .HasColumnName("name");

            entity.Property(d => d.UId)
                .HasColumnName("uid");

            entity.Property(d => d.DisplayName)
                .HasColumnName("displayname");

            entity.Property(d => d.TimeZoneId)
                .HasColumnName("timezoneid");

            entity.Property(d => d.CultureCode)
                .HasColumnName("culturecode");
        });
    }
}