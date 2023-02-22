using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EmplLoanConfiguration : IEntityTypeConfiguration<EmplLoan>
{


    public void Configure(EntityTypeBuilder<EmplLoan> builder)
    {
        builder.ToTable("Empl_Loan");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.EmpId).HasColumnName("EmpID");

        builder.Property(e => e.LoanAccountId)
            .HasMaxLength(10)
            .HasColumnName("LoanAccountID")
            .IsFixedLength();

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Num).HasMaxLength(50);

        builder.Property(e => e.Remain).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Ship).HasMaxLength(150);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.TotalAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.TotalPaidAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.UpdatedBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}