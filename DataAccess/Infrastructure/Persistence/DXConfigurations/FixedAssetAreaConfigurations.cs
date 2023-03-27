using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FixedAssetAreaConfiguration : IEntityTypeConfiguration<FixedAssetArea>
{
    public void Configure(EntityTypeBuilder<FixedAssetArea> builder)
    {
        builder.ToTable("FixedAsset_Area");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Name)
            .HasMaxLength(150)
            .HasColumnName("name");

        builder.Property(e => e.Notes).HasMaxLength(500);

        builder.Property(e => e.ParentId).HasColumnName("ParentID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}