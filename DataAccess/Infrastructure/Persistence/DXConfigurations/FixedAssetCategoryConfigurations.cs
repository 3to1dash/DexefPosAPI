using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FixedAssetCategoryConfiguration : IEntityTypeConfiguration<FixedAssetCategory>
{
    public void Configure(EntityTypeBuilder<FixedAssetCategory> builder)
    {
        builder.ToTable("FixedAssetCategory");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AreaId).HasColumnName("AreaID");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Note).HasMaxLength(600);

        builder.Property(e => e.Num).HasColumnName("num");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}