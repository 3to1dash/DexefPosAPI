using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ExpensesEntryConfiguration : IEntityTypeConfiguration<ExpensesEntry>
{
    public void Configure(EntityTypeBuilder<ExpensesEntry> builder)
    {
        builder.ToTable("Expenses_Entry");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.AllocationType).HasMaxLength(50);

        builder.Property(e => e.Amount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CostId).HasColumnName("CostID");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dat)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("DAT");

        builder.Property(e => e.DatminInvoice)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("DATMinInvoice");

        builder.Property(e => e.Datperc)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("DATPerc");

        builder.Property(e => e.DattaxId).HasColumnName("DATTaxID");

        builder.Property(e => e.DeletedBy)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.NeedCost).HasDefaultValueSql("((0))");

        builder.Property(e => e.Note).HasMaxLength(450);

        builder.Property(e => e.Num).HasMaxLength(50);

        builder.Property(e => e.ReNum).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.ShipId).HasColumnName("ShipID");

        builder.Property(e => e.SpentId).HasColumnName("SpentID");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Tax).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TaxAccountId).HasColumnName("TaxAccountID");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.TaxPerc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Total).HasColumnType("numeric(19, 5)");
    }
}