using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class StoreItemIdStyleConfiguration : IEntityTypeConfiguration<StoreItemIdStyle>
{
    public void Configure(EntityTypeBuilder<StoreItemIdStyle> builder)
    {
        builder.ToTable("StoreItemID_Style");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.ColorId).HasColumnName("ColorID");

        builder.Property(e => e.CostIn)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CostOut)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ItemId).HasColumnName("ItemID");

        builder.Property(e => e.KindCost)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

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

        builder.Property(e => e.Ordered)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.QtyIn)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.QtyOut)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Quote)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Requested)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Reserved)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SizeId).HasColumnName("SizeID");

        builder.Property(e => e.StoreId).HasColumnName("StoreID");

        builder.Property(e => e.TotalVal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TransferAsk)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TransferNeed)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");
    }
}