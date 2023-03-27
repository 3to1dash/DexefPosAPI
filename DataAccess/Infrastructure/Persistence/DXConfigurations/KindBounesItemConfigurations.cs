using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindBounesItemConfiguration : IEntityTypeConfiguration<KindBounesItem>
{
    public void Configure(EntityTypeBuilder<KindBounesItem> builder)
    {
        builder.ToTable("Kind_BounesItems");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.BounesId).HasColumnName("BounesID");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.ItemId).HasColumnName("ItemID");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.StoreId).HasColumnName("StoreID");

        builder.Property(e => e.Unite)
            .HasMaxLength(50)
            .HasColumnName("unite");
    }
}