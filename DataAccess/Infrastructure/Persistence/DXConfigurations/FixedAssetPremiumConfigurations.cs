using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FixedAssetPremiumConfiguration : IEntityTypeConfiguration<FixedAssetPremium>
{
    public void Configure(EntityTypeBuilder<FixedAssetPremium> builder)
    {
        builder.ToTable("FixedAsset_Premium");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Notes).HasMaxLength(500);

        builder.Property(e => e.Ratio).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}