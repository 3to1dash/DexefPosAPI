using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EmplSalaryCalcEntryAccountConfiguration : IEntityTypeConfiguration<EmplSalaryCalcEntryAccount>
{
    public void Configure(EntityTypeBuilder<EmplSalaryCalcEntryAccount> builder)
    {
        builder.ToTable("Empl_SalaryCalc_EntryAccounts");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.EmpId).HasColumnName("EmpID");

        builder.Property(e => e.Isdebit).HasColumnName("ISDebit");

        builder.Property(e => e.SaleryId).HasColumnName("SaleryID");

        builder.Property(e => e.Total).HasColumnType("numeric(18, 5)");
    }
}