using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FixedAssetsCategoryConfiguration : IEntityTypeConfiguration<FixedAssetsCategory>
{


    public void Configure(EntityTypeBuilder<FixedAssetsCategory> builder)
    {
        builder.ToTable("FixedAssets_Category");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AreaId).HasColumnName("AreaID");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Note).HasMaxLength(600);

        builder.Property(e => e.Num).HasColumnName("num");
    }
}