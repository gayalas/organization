using Microsoft.EntityFrameworkCore;
using OrganizationApi.Domain.Models;

namespace OrganizationApi.Infraestructure.Data;

public class OrganizationDbContext : DbContext
{
    public OrganizationDbContext(DbContextOptions<OrganizationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Organization> Organizations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Organization>(entity =>
        {
            entity.ToTable("Organization");

            entity.HasKey(o => o.OrganizationId);

            entity.Property(o => o.OrganizationId)
                .HasColumnName("OrganizationId");

            entity.Property(o => o.LegalId)
                .HasColumnName("LegalId");

            entity.Property(o => o.LegalName)
                .HasColumnName("LegalName");

            entity.Property(o => o.OrgId)
                .HasColumnName("OrgId");

            entity.Property(o => o.OrgTypeEnum)
                .HasColumnName("OrgTypeEnum");

            entity.Property(o => o.AdministrativeId)
                .HasColumnName("AdministrativeId");

            entity.Property(o => o.IsActive)
                .HasColumnName("IsActive");

            entity.Property(o => o.Address)
                .HasColumnName("Address");

            entity.Property(o => o.Email)
                .HasColumnName("Email");

            entity.Property(o => o.Phone)
                .HasColumnName("Phone");

            entity.Property(o => o.VisualIdentity)
                .HasColumnName("VisualIdentity");

            entity.Property(o => o.LogoPictureUId)
                .HasColumnName("LogoPictureUId");

            entity.Property(o => o.Url)
                .HasColumnName("Url");

            entity.Property(o => o.DateLastUpdate)
                .HasColumnName("DateLastUpdate");

            entity.Property(o => o.EthnicTypeEnum)
                .HasColumnName("EthnicTypeEnum");

            entity.Property(o => o.ReportHeaderFirstLine)
                .HasColumnName("ReportHeaderFirstLine");

            entity.Property(o => o.ReportHeaderSecondLine)
                .HasColumnName("ReportHeaderSecondLine");
        });
    }
}