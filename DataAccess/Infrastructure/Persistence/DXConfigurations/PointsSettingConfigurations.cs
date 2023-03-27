using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PointsSettingConfiguration : IEntityTypeConfiguration<PointsSetting>
{
    public void Configure(EntityTypeBuilder<PointsSetting> builder)
    {
        builder.ToTable("Points_Setting");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AmountPoint)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CalcByAmount).HasDefaultValueSql("((0))");

        builder.Property(e => e.CalcByItem).HasDefaultValueSql("((0))");

        builder.Property(e => e.CalcByVisits).HasDefaultValueSql("((0))");

        builder.Property(e => e.ReplaceAmount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ReplaceByAmount).HasDefaultValueSql("((0))");

        builder.Property(e => e.ReplaceByCust).HasDefaultValueSql("((0))");

        builder.Property(e => e.ReplaceByDiscountItem).HasDefaultValueSql("((0))");

        builder.Property(e => e.ReplaceByFreeItem).HasDefaultValueSql("((0))");

        builder.Property(e => e.ReplaceBySlice).HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Visitspoint)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");
    }
}