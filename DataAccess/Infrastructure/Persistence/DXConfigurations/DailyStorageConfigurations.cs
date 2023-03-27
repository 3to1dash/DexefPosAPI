using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailyStorageConfiguration : IEntityTypeConfiguration<DailyStorage>
{
    public void Configure(EntityTypeBuilder<DailyStorage> builder)
    {
        builder.ToTable("DailyStorage");

        builder.HasIndex(e => new {e.AccountId, e.BranchId, e.Deleted, e.Updated, e.Dt},
            "IX_DailyStorage_AccountID_BranchID_Deleted_Updated_dt_47E57");

        builder.HasIndex(e => new {e.AccountId, e.Deleted, e.Updated, e.Dt, e.BranchId},
            "IX_DailyStorage_AccountID_Deleted_Updated_dt_BranchID_960A7");

        builder.HasIndex(e => new {e.AccountId, e.WrittenBy, e.PeriodId, e.Deleted, e.Updated},
            "IX_DailyStorage_AccountID_WrittenBy_PeriodID_Deleted_Updated_7C40C");

        builder.HasIndex(e => new {e.Deleted, e.Updated}, "IX_DailyStorage_Deleted_Updated_164F2");

        builder.HasIndex(e => new {e.Deleted, e.Updated}, "IX_DailyStorage_Deleted_Updated_259FA");

        builder.HasIndex(e => new {e.Deleted, e.Updated}, "IX_DailyStorage_Deleted_Updated_3791D");

        builder.HasIndex(e => new {e.Deleted, e.Updated}, "IX_DailyStorage_Deleted_Updated_F7808");

        builder.HasIndex(e => new {e.Deleted, e.Updated, e.Dt, e.AccountId, e.BranchId},
            "IX_DailyStorage_Deleted_Updated_dt_AccountID_BranchID_91962");

        builder.HasIndex(e => e.TaskId, "IX_DailyStorage_TaskID_5F17A");

        builder.HasIndex(e => e.TaskId, "IX_DailyStorage_TaskID_AD534");

        builder.HasIndex(e => new {e.WrittenBy, e.PeriodId, e.Deleted, e.Updated},
            "IX_DailyStorage_WrittenBy_PeriodID_Deleted_Updated_F6EB6");

        builder.HasIndex(e => new {e.WrittenBy, e.PeriodId, e.Deleted, e.Updated, e.Dealing},
            "IX_DailyStorage_WrittenBy_PeriodID_Deleted_Updated_dealing_BFE38");

        builder.HasIndex(e => e.Dealing, "IX_DailyStorage_dealing_B2B1A");

        builder.HasIndex(e => new {e.BranchId, e.WrittenBy, e.Deleted, e.Updated, e.Dt},
            "missing_index_5402_5401_DailyStorage");

        builder.HasIndex(e => new {e.WrittenBy, e.Dt}, "missing_index_960_959_DailyStorage");

        builder.HasIndex(e => new {e.WrittenBy, e.Deleted, e.Updated, e.Dt}, "missing_index_962_961_DailyStorage");

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

        builder.Property(e => e.DeletedCredit).HasColumnType("money");

        builder.Property(e => e.DeletedLocalCredit).HasColumnType("money");

        builder.Property(e => e.DeletedLocalDebit).HasColumnType("money");

        builder.Property(e => e.Deleteddebit).HasColumnType("money");

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

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}