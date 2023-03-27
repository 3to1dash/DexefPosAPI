using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EmplLoanEntryConfiguration : IEntityTypeConfiguration<EmplLoanEntry>
{
    public void Configure(EntityTypeBuilder<EmplLoanEntry> builder)
    {
        builder.ToTable("Empl_loan_Entry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Amount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.LoanId).HasColumnName("LoanID");

        builder.Property(e => e.SalaryPeriodId).HasColumnName("SalaryPeriodID");
    }
}