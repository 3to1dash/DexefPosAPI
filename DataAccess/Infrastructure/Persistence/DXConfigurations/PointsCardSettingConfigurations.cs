using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PointsCardSettingConfiguration : IEntityTypeConfiguration<PointsCardSetting>
{


    public void Configure(EntityTypeBuilder<PointsCardSetting> builder)
    {
        builder.ToTable("Points_CardSetting");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Cost).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Counts).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.DestroyPoint).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Expire).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.FirstCard).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Minimum).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.NotUseExpire).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ReActivePoint).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}