using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindStyleColorConfiguration : IEntityTypeConfiguration<KindStyleColor>
{


    public void Configure(EntityTypeBuilder<KindStyleColor> builder)
    {
        builder.ToTable("kind_StyleColor");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.ColorCode).HasMaxLength(50);

        builder.Property(e => e.ColorId).HasColumnName("ColorID");

        builder.Property(e => e.ItemId).HasColumnName("ItemID");

        builder.Property(e => e.KindId).HasColumnName("KindID");
    }
}