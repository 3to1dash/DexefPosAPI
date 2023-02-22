using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PotFeatureConfiguration : IEntityTypeConfiguration<PotFeature>
{


    public void Configure(EntityTypeBuilder<PotFeature> builder)
    {
        builder.ToTable("Pot_Features");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Custid).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Ischeck).HasColumnName("ISCheck");

        builder.Property(e => e.ItemId).HasColumnName("ItemID");

        builder.Property(e => e.Kind)
            .HasMaxLength(50)
            .HasColumnName("kind");

        builder.Property(e => e.Price)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");
    }
}