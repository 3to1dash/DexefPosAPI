using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class MaintenanceExtraConfiguration : IEntityTypeConfiguration<MaintenanceExtra>
{


    public void Configure(EntityTypeBuilder<MaintenanceExtra> builder)
    {
        builder.ToTable("MaintenanceExtra");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Isedit).HasColumnName("ISEdit");

        builder.Property(e => e.Isvalue).HasColumnName("ISValue");

        builder.Property(e => e.Name)
            .HasMaxLength(150)
            .HasColumnName("name");

        builder.Property(e => e.PriceWithinWarranty).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Priceoutsidewarranty).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}