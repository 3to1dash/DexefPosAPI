using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailyKindConfiguration : IEntityTypeConfiguration<DailyKind>
{


    public void Configure(EntityTypeBuilder<DailyKind> builder)
    {
        builder.ToTable("DailyKind");

        builder.HasIndex(e => new { e.ItemId, e.Deleted, e.Updated, e.Dt }, "IX_DailyKind_ItemID_Deleted_Updated_dt_462A4");

        builder.HasIndex(e => new { e.ItemId, e.Deleted, e.Updated, e.Dt }, "IX_DailyKind_ItemID_Deleted_Updated_dt_B7324");

        builder.HasIndex(e => e.ItemId, "IX_DailyKind_ItemID_E451C");

        builder.HasIndex(e => new { e.ItemId, e.Dealing }, "IX_DailyKind_ItemID_dealing_1FC19");

        builder.HasIndex(e => e.KindId, "IX_DailyKind_KindID_48C90");

        builder.HasIndex(e => e.TaskId, "IX_DailyKind_TaskID_CF3B8");

        builder.HasIndex(e => e.TaskId, "IX_DailyKind_TaskID_DB9BD");

        builder.HasIndex(e => e.Dealing, "IX_DailyKind_dealing_06643");

        builder.HasIndex(e => new { e.Num, e.Dealing, e.BranchId }, "IX_DailyKind_num_dealing_BranchID_2C438");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Bounes)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CashDiscount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ColorId).HasColumnName("ColorID");

        builder.Property(e => e.CostId).HasColumnName("CostID");

        builder.Property(e => e.CostPrice)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Cpu).HasDefaultValueSql("((0))");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .HasColumnName("dealing");

        builder.Property(e => e.Deleted).HasDefaultValueSql("((0))");

        builder.Property(e => e.DeletedBy)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Discount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.ExprDt)
            .HasColumnType("datetime")
            .HasColumnName("ExprDT");

        builder.Property(e => e.Extra).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ItemId).HasColumnName("ItemID");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.NetPrice)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Num)
            .HasMaxLength(50)
            .HasColumnName("num");

        builder.Property(e => e.Operate).HasMaxLength(50);

        builder.Property(e => e.PeriodId)
            .HasColumnName("PeriodID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Price)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Qty).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Qty1In)
            .HasColumnType("numeric(19, 5)")
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

        builder.Property(e => e.QtyDiscount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.QtyIn)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.QtyOut)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rate)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((1))");

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

        builder.Property(e => e.Tax)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Total).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TotalCost)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TotalIn)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("TotalIN")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TotalOut)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Unite)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Updated).HasDefaultValueSql("((0))");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}