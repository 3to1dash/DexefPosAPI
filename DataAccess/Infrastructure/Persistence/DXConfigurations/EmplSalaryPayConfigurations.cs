using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EmplSalaryPayConfiguration : IEntityTypeConfiguration<EmplSalaryPay>
{


    public void Configure(EntityTypeBuilder<EmplSalaryPay> builder)
    {
        builder.ToTable("Empl_SalaryPay");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Note).HasMaxLength(400);

        builder.Property(e => e.Num).HasMaxLength(50);

        builder.Property(e => e.PayId).HasColumnName("PayID");

        builder.Property(e => e.SalaryGroupId).HasColumnName("SalaryGroupID");

        builder.Property(e => e.SalaryPeriodId).HasColumnName("SalaryPeriodID");

        builder.Property(e => e.Ship).HasMaxLength(150);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.TotalAnnualIncrease).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.TotalAttendees).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.TotalBouns).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.TotalChangedSalary).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.TotalDiscounts).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.TotalInsurances).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.TotalLoan).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.TotalNetSalary).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.TotalSalary).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.TotalTaxes).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.UpdatedBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}