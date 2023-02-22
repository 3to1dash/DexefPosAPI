using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class MaintenanceDamageConfiguration : IEntityTypeConfiguration<MaintenanceDamage>
{


    public void Configure(EntityTypeBuilder<MaintenanceDamage> builder)
    {
        builder.ToTable("MaintenanceDamage");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Note).HasMaxLength(500);

        builder.Property(e => e.ParentId).HasColumnName("ParentID");
    }
}