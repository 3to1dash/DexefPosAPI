using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailyInvoiceExpenseConfiguration : IEntityTypeConfiguration<DailyInvoiceExpense>
{


    public void Configure(EntityTypeBuilder<DailyInvoiceExpense> builder)
    {
        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.Allocation).HasMaxLength(50);

        builder.Property(e => e.Amount).HasColumnType("money");

        builder.Property(e => e.BillNum)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Cpu).HasColumnName("CPU");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .HasColumnName("dealing");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.ExpensesId).HasColumnName("ExpensesID");

        builder.Property(e => e.InvoiceAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.InvoiceRate).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.IsCompanyExpense).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsValue).HasDefaultValueSql("((0))");

        builder.Property(e => e.NetAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.PeriodId).HasColumnName("PeriodID");

        builder.Property(e => e.Rate)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Tax)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TaxPerc)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Taxable).HasDefaultValueSql("((0))");

        builder.Property(e => e.Total)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Value)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Writtenby).HasMaxLength(50);
    }
}