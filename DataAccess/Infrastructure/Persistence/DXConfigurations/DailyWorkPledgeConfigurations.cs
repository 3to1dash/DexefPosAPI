using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailyWorkPledgeConfiguration : IEntityTypeConfiguration<DailyWorkPledge>
{
    public void Configure(EntityTypeBuilder<DailyWorkPledge> builder)
    {
        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.ActualRate)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CostId)
            .HasColumnName("CostID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Cpu).HasColumnName("CPU");

        builder.Property(e => e.Credit)
            .HasColumnType("numeric(19, 5)")
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
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("debit")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Deleted).HasDefaultValueSql("((0))");

        builder.Property(e => e.DeletedBy)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.EmpId).HasColumnName("EmpID");

        builder.Property(e => e.LocalCredit)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.LocalDebit)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Note).HasColumnName("note");

        builder.Property(e => e.Num)
            .HasMaxLength(50)
            .HasColumnName("num");

        builder.Property(e => e.PeriodId)
            .HasColumnName("PeriodID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rate)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((1))");

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