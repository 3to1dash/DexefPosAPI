using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class StoreItemIdConfiguration : IEntityTypeConfiguration<StoreItemId>
{


    public void Configure(EntityTypeBuilder<StoreItemId> builder)
    {
        builder.ToTable("StoreItemID");

        builder.HasIndex(e => e.KindId, "IX_StoreItemID_KindID_4D490");

        builder.HasIndex(e => e.Maximum, "IX_StoreItemID_Maximum_F5A82");

        builder.HasIndex(e => e.Minimum, "IX_StoreItemID_Minimum_223D3");

        builder.HasIndex(e => e.StoreId, "IX_StoreItemID_StoreID_35B5C");

        builder.HasIndex(e => e.StoreId, "IX_StoreItemID_StoreID_B2300");

        builder.HasIndex(e => new { e.StoreId, e.KindId }, "NonClusteredIndex-20200113-222147");

        builder.HasIndex(e => new { e.StoreId, e.TotalVal }, "missing_index_5461_5460_StoreItemID");

        builder.HasIndex(e => new { e.StoreId, e.Id }, "missing_index_68_67_StoreItemID");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Address)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Address1).HasMaxLength(50);

        builder.Property(e => e.Address2).HasMaxLength(50);

        builder.Property(e => e.CostIn)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CostOut)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ExprDt)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.FixedSale)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

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

        builder.Property(e => e.Maximum)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Minimum)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.OpenBalance)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.OpenCost)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.OpenQty1).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.OpenQty2).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.OpenRegNum)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.OpenSerial).HasDefaultValueSql("('')");

        builder.Property(e => e.OpenTaskId)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("OpenTaskID");

        builder.Property(e => e.OpenUnite)
            .HasMaxLength(50)
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.OrderCounts).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Ordered)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Qty1In)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("Qty1IN")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Qty1Out)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Qty2In)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("Qty2IN")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Qty2Out)
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