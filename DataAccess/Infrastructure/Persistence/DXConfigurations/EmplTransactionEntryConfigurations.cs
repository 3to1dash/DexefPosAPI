using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EmplTransactionEntryConfiguration : IEntityTypeConfiguration<EmplTransactionEntry>
{
    public void Configure(EntityTypeBuilder<EmplTransactionEntry> builder)
    {
        builder.ToTable("Empl_Transaction_Entry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.EmpId).HasColumnName("EmpID");

        builder.Property(e => e.IsfixedAmount).HasColumnName("ISFixedAmount");

        builder.Property(e => e.PayrollItemId).HasColumnName("PayrollItemID");

        builder.Property(e => e.TransactionId).HasColumnName("TransactionID");

        builder.Property(e => e.Value).HasColumnType("numeric(18, 5)");
    }
}