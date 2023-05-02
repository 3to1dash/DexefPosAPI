using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FixedAssetDepreciationConfiguration : IEntityTypeConfiguration<FixedAssetDepreciation>
{
    public void Configure(EntityTypeBuilder<FixedAssetDepreciation> builder)
    {
        builder.ToTable("FixedAsset_Depreciation");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.DepName).HasMaxLength(150);

        builder.Property(e => e.DestoryDiscountId).HasColumnName("DestoryDiscountID");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Ratio).HasColumnType("numeric(18, 2)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}