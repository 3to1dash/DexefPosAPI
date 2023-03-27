using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EmpDailyPayrollConfiguration : IEntityTypeConfiguration<EmpDailyPayroll>
{
    public void Configure(EntityTypeBuilder<EmpDailyPayroll> builder)
    {
        builder.ToTable("Emp_DailyPayroll");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Calced).HasDefaultValueSql("((0))");

        builder.Property(e => e.Credit).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Debit).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Deleted).HasDefaultValueSql("((0))");

        builder.Property(e => e.DeletedBy)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.EmplId).HasColumnName("EmplID");

        builder.Property(e => e.Num).HasMaxLength(50);

        builder.Property(e => e.PayrollItemId).HasColumnName("PayrollItemID");

        builder.Property(e => e.PeriodId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("PeriodID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.SalaryPeriodId).HasColumnName("SalaryPeriodID");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Updated).HasDefaultValueSql("((0))");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}