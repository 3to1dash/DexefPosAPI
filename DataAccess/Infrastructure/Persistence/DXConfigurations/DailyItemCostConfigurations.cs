using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailyItemCostConfiguration : IEntityTypeConfiguration<DailyItemCost>
{


    public void Configure(EntityTypeBuilder<DailyItemCost> builder)
    {
        builder.ToTable("Daily_ItemCost");

        builder.HasIndex(e => new { e.BranchId, e.Num, e.Dealing }, "IX_Daily_ItemCost_BranchID_Num_Dealing_B9F32");

        builder.HasIndex(e => e.Dealing, "IX_Daily_ItemCost_Dealing_702B6");

        builder.HasIndex(e => new { e.Dealing, e.ItemCost }, "IX_Daily_ItemCost_Dealing_ItemCost_EC772");

        builder.HasIndex(e => new { e.Dealing, e.TranCode }, "IX_Daily_ItemCost_Dealing_TranCode_4DA94");

        builder.HasIndex(e => new { e.Dealing, e.TranCode }, "IX_Daily_ItemCost_Dealing_TranCode_602BD");

        builder.HasIndex(e => new { e.Dealing, e.TranCode }, "IX_Daily_ItemCost_Dealing_TranCode_69B39");

        builder.HasIndex(e => e.Dt, "IX_Daily_ItemCost_Dt_4C275");

        builder.HasIndex(e => e.ItemId, "IX_Daily_ItemCost_ItemID_0BFCB");

        builder.HasIndex(e => new { e.ItemId, e.Dt, e.TranCode, e.TaskId }, "IX_Daily_ItemCost_ItemID_Dt_TranCode_TaskID_CFFFD");

        builder.HasIndex(e => new { e.ItemId, e.TranCode }, "IX_Daily_ItemCost_ItemID_TranCode_4C0CE");

        builder.HasIndex(e => new { e.ItemId, e.TranCode }, "IX_Daily_ItemCost_ItemID_TranCode_93EB3");

        builder.HasIndex(e => new { e.ItemId, e.TranCode }, "IX_Daily_ItemCost_ItemID_TranCode_ADE94");

        builder.HasIndex(e => e.NetPrice, "IX_Daily_ItemCost_NetPrice_2B48B");

        builder.HasIndex(e => e.Rate, "IX_Daily_ItemCost_Rate_2290D");

        builder.HasIndex(e => e.TaskId, "IX_Daily_ItemCost_TaskID_26C23");

        builder.HasIndex(e => e.TranCode, "IX_Daily_ItemCost_TranCode_A3ACD");

        builder.HasIndex(e => new { e.TranCode, e.Dealing }, "IX_Daily_ItemCost_TranCode_Dealing_9FAD4");

        builder.HasIndex(e => new { e.StoreId, e.Dt }, "missing_index_1107_1106_Daily_ItemCost");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.TranCode }, "missing_index_3443_3442_Daily_ItemCost");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Bonus)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("bonus")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.ColorId).HasColumnName("ColorID");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.DealingPrice)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DealingQty).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.DealingUnite).HasMaxLength(50);

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.ItemCost).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.ItemId)
            .HasColumnName("ItemID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.NetPrice)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.NewCost)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Num).HasMaxLength(50);

        builder.Property(e => e.Qty)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SizeId).HasColumnName("SizeID");

        builder.Property(e => e.StoreId).HasColumnName("StoreID");

        builder.Property(e => e.StyleId).HasColumnName("StyleID");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.TempInsertedRowId).HasColumnName("TempInsertedRowID");

        builder.Property(e => e.TranCode)
            .HasMaxLength(3)
            .IsUnicode(false);

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}