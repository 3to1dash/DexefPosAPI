using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ItemStyleSearchConfiguration : IEntityTypeConfiguration<ItemStyleSearch>
{
    public void Configure(EntityTypeBuilder<ItemStyleSearch> builder)
    {
        builder.HasNoKey();

        builder.ToView("ItemStyleSearch");

        builder.Property(e => e.BranchName).HasMaxLength(50);

        builder.Property(e => e.ColorId).HasColumnName("ColorID");

        builder.Property(e => e.ColorName).HasMaxLength(150);

        builder.Property(e => e.CostIn).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.CostOut).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.ItemCode)
            .HasMaxLength(50)
            .IsUnicode(false);

        builder.Property(e => e.ItemId).HasColumnName("ItemID");

        builder.Property(e => e.KindCost).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.LinPrice)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("linPrice");

        builder.Property(e => e.LinQty)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("linQty");

        builder.Property(e => e.LinUnite).HasMaxLength(50);

        builder.Property(e => e.Lindt)
            .HasColumnType("datetime")
            .HasColumnName("lindt");

        builder.Property(e => e.LoutDt).HasColumnType("datetime");

        builder.Property(e => e.LoutPrice).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.LoutQty)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("loutQty");

        builder.Property(e => e.LoutUnite).HasMaxLength(50);

        builder.Property(e => e.OrderCounts).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Ordered).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.QtyIn).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.QtyOut).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Quote).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Requested).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Reserved).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.SizeId).HasColumnName("SizeID");

        builder.Property(e => e.SizeName).HasMaxLength(150);

        builder.Property(e => e.StoreId).HasColumnName("StoreID");

        builder.Property(e => e.StoreName).HasMaxLength(50);

        builder.Property(e => e.TotalVal).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TransferAsk).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TransferNeed).HasColumnType("numeric(19, 5)");
    }
}