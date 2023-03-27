using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ItemColorConfiguration : IEntityTypeConfiguration<ItemColor>
{
    public void Configure(EntityTypeBuilder<ItemColor> builder)
    {
        builder.HasNoKey();

        builder.ToView("ItemColor");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.Name)
            .HasMaxLength(150)
            .HasColumnName("name");

        builder.Property(e => e.StoreId).HasColumnName("StoreID");
    }
}