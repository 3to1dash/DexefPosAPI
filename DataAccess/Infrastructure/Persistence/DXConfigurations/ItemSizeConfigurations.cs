using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ItemSizeConfiguration : IEntityTypeConfiguration<ItemSize>
{
    public void Configure(EntityTypeBuilder<ItemSize> builder)
    {
        builder.HasNoKey();

        builder.ToView("ItemSize");

        builder.Property(e => e.ColorId).HasColumnName("ColorID");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.Name)
            .HasMaxLength(150)
            .HasColumnName("name");

        builder.Property(e => e.StoreId).HasColumnName("StoreID");
    }
}