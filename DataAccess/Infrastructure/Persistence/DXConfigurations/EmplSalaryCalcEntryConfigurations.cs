using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EmplSalaryCalcEntryConfiguration : IEntityTypeConfiguration<EmplSalaryCalcEntry>
{
    public void Configure(EntityTypeBuilder<EmplSalaryCalcEntry> builder)
    {
        builder.ToTable("Empl_SalaryCalc_Entry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AnnualIncrease).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Attendees).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Bouns).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.ChangedSalary).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Discounts).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.EmpId).HasColumnName("EmpID");

        builder.Property(e => e.Insurances).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.LoanValue).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.NetSalary).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Salary).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.SaleryId).HasColumnName("SaleryID");

        builder.Property(e => e.Taxes).HasColumnType("numeric(18, 5)");
    }
}