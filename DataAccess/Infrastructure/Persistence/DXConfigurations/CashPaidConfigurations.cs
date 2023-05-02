using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CashPaidConfiguration : IEntityTypeConfiguration<CashPaid>
{
    public void Configure(EntityTypeBuilder<CashPaid> builder)
    {
        builder.ToTable("Cash_Paid");

        builder.HasIndex(e => e.BranchId, "IX_Cash_Paid_BranchID_D3A02");

        builder.HasIndex(e => new {e.Dafter, e.BranchId}, "IX_Cash_Paid_Dafter_BranchID_2B748");

        builder.HasIndex(e => e.TaskId, "IX_Cash_Paid_TaskID_AC1E1");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Attached).HasDefaultValueSql("((0))");

        builder.Property(e => e.BillNum).HasMaxLength(50);

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CapitalId).HasColumnName("CapitalID");

        builder.Property(e => e.CashDiscount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CostId).HasColumnName("CostID");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.CustId)
            .HasColumnName("CustID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dafter)
            .HasMaxLength(20)
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DeletedBy)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Discount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountId)
            .HasColumnName("DiscountID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.Dthijri)
            .HasMaxLength(19)
            .IsUnicode(false)
            .HasColumnName("DTHijri")
            .IsFixedLength();

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Note)
            .HasMaxLength(500)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Num).HasDefaultValueSql("((0))");

        builder.Property(e => e.PeriodId).HasColumnName("PeriodID");

        builder.Property(e => e.ProcessId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("ProcessID");

        builder.Property(e => e.Rate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.ReNum)
            .HasMaxLength(50)
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Tax)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TaxId)
            .HasColumnName("TaxID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TaxPerc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.UpdateBy).HasMaxLength(50);

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}