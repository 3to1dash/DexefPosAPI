using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailyBankConfiguration : IEntityTypeConfiguration<DailyBank>
{


    public void Configure(EntityTypeBuilder<DailyBank> builder)
    {
        builder.ToTable("DailyBank");

        builder.HasIndex(e => new { e.AccountId, e.BranchId, e.Deleted, e.Updated, e.Dt }, "IX_DailyBank_AccountID_BranchID_Deleted_Updated_dt_DC880");

        builder.HasIndex(e => new { e.AccountId, e.Deleted, e.Updated }, "IX_DailyBank_AccountID_Deleted_Updated_0FC67");

        builder.HasIndex(e => new { e.AccountId, e.Deleted, e.Updated, e.Dt, e.BranchId }, "IX_DailyBank_AccountID_Deleted_Updated_dt_BranchID_CB5D6");

        builder.HasIndex(e => new { e.AccountId, e.TaskId }, "IX_DailyBank_AccountID_TaskID_94897");

        builder.HasIndex(e => new { e.AccountId, e.Dealing }, "IX_DailyBank_AccountID_dealing_9E9FD");

        builder.HasIndex(e => new { e.BranchId, e.RegNum, e.TaskId }, "IX_DailyBank_BranchID_RegNum_TaskID_49C3F");

        builder.HasIndex(e => new { e.Deleted, e.Updated }, "IX_DailyBank_Deleted_Updated_26D2C");

        builder.HasIndex(e => new { e.Deleted, e.Updated }, "IX_DailyBank_Deleted_Updated_8F564");

        builder.HasIndex(e => new { e.Deleted, e.Updated }, "IX_DailyBank_Deleted_Updated_AC7F7");

        builder.HasIndex(e => new { e.Deleted, e.Updated }, "IX_DailyBank_Deleted_Updated_BC004");

        builder.HasIndex(e => new { e.Deleted, e.Updated, e.Dt }, "IX_DailyBank_Deleted_Updated_dt_08175");

        builder.HasIndex(e => new { e.Deleted, e.Updated, e.Dt, e.AccountId, e.BranchId }, "IX_DailyBank_Deleted_Updated_dt_AccountID_BranchID_04E7D");

        builder.HasIndex(e => new { e.Deleted, e.Updated, e.Dt }, "IX_DailyBank_Deleted_Updated_dt_CD375");

        builder.HasIndex(e => new { e.Deleted, e.Updated, e.Dt, e.Currency }, "IX_DailyBank_Deleted_Updated_dt_Currency_D8B4B");

        builder.HasIndex(e => new { e.Deleted, e.Updated, e.Dt }, "IX_DailyBank_Deleted_Updated_dt_D8EC8");

        builder.HasIndex(e => new { e.TaskId, e.Deleted, e.Updated }, "IX_DailyBank_TaskID_Deleted_Updated_61969");

        builder.HasIndex(e => e.Dealing, "IX_DailyBank_dealing_EADBE");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("AccountID");

        builder.Property(e => e.ActualRate)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.CostId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CostID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Cpu)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CPU");

        builder.Property(e => e.Credit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("credit")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .HasColumnName("dealing");

        builder.Property(e => e.Debit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("debit")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Deleted).HasDefaultValueSql("((0))");

        builder.Property(e => e.DeletedBy)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.LocalCredit)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.LocalDebit)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Note).HasColumnName("note");

        builder.Property(e => e.Num)
            .HasMaxLength(50)
            .HasColumnName("num");

        builder.Property(e => e.PeriodId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("PeriodID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rate)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(250);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Updated).HasDefaultValueSql("((0))");

        builder.Property(e => e.Value)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.VisaId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("VisaID");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}