using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class InvoiceExpensesLogConfiguration : IEntityTypeConfiguration<InvoiceExpensesLog>
{
    public void Configure(EntityTypeBuilder<InvoiceExpensesLog> builder)
    {
        builder.ToTable("InvoiceExpenses_Log");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.Allocation).HasMaxLength(50);

        builder.Property(e => e.CoExpenses)
            .HasColumnType("decimal(32, 17)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CostId)
            .HasColumnName("CostID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CostPaying).HasMaxLength(50);

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.ExpenseId).HasColumnName("ExpenseID");

        builder.Property(e => e.InvoiceAmount)
            .HasColumnType("decimal(32, 17)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InvoiceCurrency).HasMaxLength(3);

        builder.Property(e => e.InvoiceExpenses)
            .HasColumnType("decimal(32, 17)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InvoiceRate)
            .HasColumnType("decimal(32, 17)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InvoiceTaxes)
            .HasColumnType("decimal(32, 17)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.MainInvoiceRate).HasColumnType("decimal(32, 17)");

        builder.Property(e => e.NetAmount)
            .HasColumnType("decimal(32, 17)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.OtherCustExpenses)
            .HasColumnType("decimal(32, 17)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rate)
            .HasColumnType("decimal(32, 17)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Tax)
            .HasColumnType("decimal(32, 17)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.TaxPerc)
            .HasColumnType("decimal(32, 17)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Taxable)
            .HasMaxLength(10)
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Total).HasColumnType("decimal(32, 17)");

        builder.Property(e => e.Value)
            .HasColumnType("decimal(32, 17)")
            .HasDefaultValueSql("((0))");
    }
}