using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TripExcelSettingConfiguration : IEntityTypeConfiguration<TripExcelSetting>
{


    public void Configure(EntityTypeBuilder<TripExcelSetting> builder)
    {
        builder.ToTable("Trip_ExcelSettings");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Chd)
            .HasMaxLength(50)
            .HasColumnName("CHD");

        builder.Property(e => e.Domestic).HasMaxLength(50);

        builder.Property(e => e.Emd).HasMaxLength(50);

        builder.Property(e => e.Gds).HasColumnName("GDS");

        builder.Property(e => e.InOutTrip).HasMaxLength(50);

        builder.Property(e => e.InTrip).HasMaxLength(50);

        builder.Property(e => e.International).HasMaxLength(50);

        builder.Property(e => e.OutTrip).HasMaxLength(50);

        builder.Property(e => e.Refund).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Tiket).HasMaxLength(50);

        builder.Property(e => e.Void).HasMaxLength(50);
    }
}