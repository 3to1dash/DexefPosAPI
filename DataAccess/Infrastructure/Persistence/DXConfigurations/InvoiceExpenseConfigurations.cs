using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class InvoiceExpenseConfiguration : IEntityTypeConfiguration<InvoiceExpense>
{


    public void Configure(EntityTypeBuilder<InvoiceExpense> builder)
    {
        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.Allocation).HasMaxLength(50);

        builder.Property(e => e.ArName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.ChName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.CostId)
            .HasColumnName("CostID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CostPaying).HasMaxLength(50);

        builder.Property(e => e.CostType).HasDefaultValueSql("((0))");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.EnName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.FrName).HasMaxLength(150);

        builder.Property(e => e.Note).HasMaxLength(450);

        builder.Property(e => e.RoName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.RuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.TaxPerc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Taxable)
            .HasMaxLength(10)
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");
    }
}