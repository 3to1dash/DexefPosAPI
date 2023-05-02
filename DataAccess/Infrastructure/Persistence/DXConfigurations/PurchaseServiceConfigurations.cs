using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PurchaseServiceConfiguration : IEntityTypeConfiguration<PurchaseService>
{
    public void Configure(EntityTypeBuilder<PurchaseService> builder)
    {
        builder.ToTable("PurchaseService");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.BillNum).HasMaxLength(50);

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CostId).HasColumnName("CostID");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.CustType).HasMaxLength(50);

        builder.Property(e => e.Dafter).HasMaxLength(20);

        builder.Property(e => e.Discount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.DiscountVal).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.Dthijri)
            .HasMaxLength(19)
            .IsUnicode(false)
            .HasColumnName("DTHijri")
            .IsFixedLength();

        builder.Property(e => e.IncomeId).HasColumnName("IncomeID");

        builder.Property(e => e.IsPaid).HasDefaultValueSql("((0))");

        builder.Property(e => e.ItemCounts).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Note).HasMaxLength(450);

        builder.Property(e => e.Paid).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.ReNum).HasMaxLength(50);

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Remain).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(250);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Tax).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.TaxPerc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Total).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.UpdateBy).HasMaxLength(50);

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}