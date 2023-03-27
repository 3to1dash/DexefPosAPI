using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailyVisaConfiguration : IEntityTypeConfiguration<DailyVisa>
{
    public void Configure(EntityTypeBuilder<DailyVisa> builder)
    {
        builder.ToTable("DailyVisa");

        builder.HasIndex(e => new {e.AccountId, e.BranchId, e.Deleted, e.Updated, e.Dt},
            "IX_DailyVisa_AccountID_BranchID_Deleted_Updated_dt_23936");

        builder.HasIndex(e => new {e.AccountId, e.Deleted, e.Updated, e.Dt, e.BranchId},
            "IX_DailyVisa_AccountID_Deleted_Updated_dt_BranchID_B342B");

        builder.HasIndex(e => new {e.AccountId, e.Dealing}, "IX_DailyVisa_AccountID_dealing_7D08F");

        builder.HasIndex(e => new {e.Deleted, e.Updated}, "IX_DailyVisa_Deleted_Updated_9179B");

        builder.HasIndex(e => new {e.Deleted, e.Updated}, "IX_DailyVisa_Deleted_Updated_B0B3A");

        builder.HasIndex(e => new {e.Deleted, e.Updated}, "IX_DailyVisa_Deleted_Updated_F771B");

        builder.HasIndex(e => new {e.Deleted, e.Updated, e.Dt}, "IX_DailyVisa_Deleted_Updated_dt_277FD");

        builder.HasIndex(e => new {e.TaskId, e.Deleted, e.Updated}, "IX_DailyVisa_TaskID_Deleted_Updated_A73DE");

        builder.HasIndex(e => e.Dealing, "IX_DailyVisa_dealing_05C9F");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("AccountID");

        builder.Property(e => e.ActualRate)
            .HasColumnType("numeric(19, 5)")
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

        builder.Property(e => e.MaxNum).HasColumnType("numeric(18, 0)");

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
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}