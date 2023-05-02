using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FixedAssetRentMethodConfiguration : IEntityTypeConfiguration<FixedAssetRentMethod>
{
    public void Configure(EntityTypeBuilder<FixedAssetRentMethod> builder)
    {
        builder.ToTable("FixedAssetRentMethod");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Name)
            .HasMaxLength(250)
            .HasColumnName("name");

        builder.Property(e => e.PeriodType).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.UpdatedBy).HasMaxLength(50);

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}