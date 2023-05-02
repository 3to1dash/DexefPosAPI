using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FixedAssetRentOptEntryConfiguration : IEntityTypeConfiguration<FixedAssetRentOptEntry>
{
    public void Configure(EntityTypeBuilder<FixedAssetRentOptEntry> builder)
    {
        builder.ToTable("FixedAssetRentOptEntry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AssetId).HasColumnName("AssetID");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.Insurance)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.MethodId).HasColumnName("MethodID");

        builder.Property(e => e.Num).HasColumnName("num");

        builder.Property(e => e.OptId).HasColumnName("OptID");

        builder.Property(e => e.RentPrice)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TotalRent).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.UpdatedBy).HasMaxLength(50);

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}