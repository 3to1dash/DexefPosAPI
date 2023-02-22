using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FixedAssetMasterDepreciationConfiguration : IEntityTypeConfiguration<FixedAssetMasterDepreciation>
{


    public void Configure(EntityTypeBuilder<FixedAssetMasterDepreciation> builder)
    {
        builder.ToTable("FixedAssetMaster_Depreciation");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AssetId).HasColumnName("AssetID");

        builder.Property(e => e.AssetValue).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.DepreciationRatio).HasColumnType("numeric(18, 2)");

        builder.Property(e => e.DtDepreciation).HasColumnType("datetime");

        builder.Property(e => e.Notes).HasMaxLength(500);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.ScarpValue).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Value).HasColumnType("numeric(18, 5)");
    }
}