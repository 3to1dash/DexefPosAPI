using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkPayInsuranceConfiguration : IEntityTypeConfiguration<WorkPayInsurance>
{
    public void Configure(EntityTypeBuilder<WorkPayInsurance> builder)
    {
        builder.ToTable("Work_PayInsurance");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.Changed)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Done).HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.ExpenseId).HasColumnName("ExpenseID");

        builder.Property(e => e.Fixed)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.IsSelect).HasDefaultValueSql("((0))");

        builder.Property(e => e.Iscompany)
            .HasColumnName("ISCompany")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.MonthDt).HasColumnType("datetime");

        builder.Property(e => e.Num).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.PaidValue)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Remain)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(150);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WorkId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("WorkID");
    }
}