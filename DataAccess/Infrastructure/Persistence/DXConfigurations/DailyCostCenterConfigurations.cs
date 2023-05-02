using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailyCostCenterConfiguration : IEntityTypeConfiguration<DailyCostCenter>
{
    public void Configure(EntityTypeBuilder<DailyCostCenter> builder)
    {
        builder.ToTable("DailyCostCenter");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

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

        builder.Property(e => e.ParentShip).HasMaxLength(450);

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

        builder.Property(e => e.Ship).HasMaxLength(450);

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