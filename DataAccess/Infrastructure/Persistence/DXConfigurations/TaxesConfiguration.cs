using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TaxesConfiguration : IEntityTypeConfiguration<Taxes>
{
    public void Configure(EntityTypeBuilder<Taxes> builder)
    {
        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Active).HasColumnName("active");

        builder.Property(e => e.Category)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasDefaultValueSql("(N'T1')");

        builder.Property(e => e.Datid).HasColumnName("DATID");

        builder.Property(e => e.DatminInvoice)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("DATMinInvoice")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Datperc)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("DATPerc");

        builder.Property(e => e.ItemType).HasMaxLength(50);

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Num).HasColumnName("num");

        builder.Property(e => e.Perc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.PurchaseTax)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SaleTax)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.SubCategory)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasDefaultValueSql("(N'V009')");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.TaxType).HasMaxLength(50);

        builder.Property(e => e.Updated).HasDefaultValueSql("((0))");

        builder.Property(e => e.UseDat).HasColumnName("UseDAT");

        builder.HasOne(d => d.CategoryNavigation)
            .WithMany(p => p.Taxes)
            .HasForeignKey(d => d.Category)
            .HasConstraintName("FK_Taxes_Taxes_Group");

        builder.HasOne(d => d.SubCategoryNavigation)
            .WithMany(p => p.Taxes)
            .HasForeignKey(d => d.SubCategory)
            .HasConstraintName("FK_Taxes_Taxes_SubGroup");
    }
}