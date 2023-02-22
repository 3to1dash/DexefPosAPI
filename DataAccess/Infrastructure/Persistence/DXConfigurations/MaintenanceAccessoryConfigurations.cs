using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class MaintenanceAccessoryConfiguration : IEntityTypeConfiguration<MaintenanceAccessory>
{


    public void Configure(EntityTypeBuilder<MaintenanceAccessory> builder)
    {
        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.LastUpdate).HasColumnType("datetime");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.UpdatedBy).HasMaxLength(50);

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}