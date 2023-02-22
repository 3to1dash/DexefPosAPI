using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class StoreAdjustmentEntryConfiguration : IEntityTypeConfiguration<StoreAdjustmentEntry>
{


    public void Configure(EntityTypeBuilder<StoreAdjustmentEntry> builder)
    {
        builder.ToTable("StoreAdjustment_Entry");

        builder.HasIndex(e => new { e.TaskId, e.DiffCost }, "IX_StoreAdjustment_Entry_TaskID_DiffCost_154A2");

        builder.HasIndex(e => new { e.TaskId, e.DiffQty1 }, "IX_StoreAdjustment_Entry_TaskID_DiffQty1_620EF");

        builder.HasIndex(e => new { e.TaskId, e.DiffQty2 }, "IX_StoreAdjustment_Entry_TaskID_DiffQty2_D0EE3");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BatchId).HasColumnName("BatchID");

        builder.Property(e => e.BillNum)
            .HasMaxLength(50)
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Code)
            .HasMaxLength(50)
            .HasColumnName("code");

        builder.Property(e => e.ColorId).HasColumnName("ColorID");

        builder.Property(e => e.Cost)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CostId).HasColumnName("CostID");

        builder.Property(e => e.Currency).HasMaxLength(5);

        builder.Property(e => e.CurrentCost)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CurrentQty)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CurrentQty1)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CurrentQty2)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DealType).HasMaxLength(10);

        builder.Property(e => e.DiffCost)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiffQty)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiffQty1)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiffQty2)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.ExprDt)
            .HasColumnType("datetime")
            .HasColumnName("ExprDT");

        builder.Property(e => e.IsIn).HasDefaultValueSql("((0))");

        builder.Property(e => e.ItemCost)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ItemId)
            .HasColumnName("ItemID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.NetPrice).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Operate).HasMaxLength(50);

        builder.Property(e => e.Optkind).HasColumnName("optkind");

        builder.Property(e => e.Qty)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Qty1)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Qty2)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RowId).HasColumnName("RowID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SizeId).HasColumnName("SizeID");

        builder.Property(e => e.StoreId).HasColumnName("StoreID");

        builder.Property(e => e.StyleId).HasColumnName("StyleID");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.TransCode).HasMaxLength(10);

        builder.Property(e => e.Unite)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UniteCost)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");
    }
}