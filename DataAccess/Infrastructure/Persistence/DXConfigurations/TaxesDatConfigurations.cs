using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TaxesDatConfiguration : IEntityTypeConfiguration<TaxesDat>
{


    public void Configure(EntityTypeBuilder<TaxesDat> builder)
    {
        builder.ToTable("TaxesDAT");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.Active).HasColumnName("active");

        builder.Property(e => e.Category)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasDefaultValueSql("(N'T1')");

        builder.Property(e => e.DatminInvoice)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("DATMinInvoice")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Num).HasColumnName("num");

        builder.Property(e => e.Perc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.StartCalcDate).HasColumnType("datetime");

        builder.Property(e => e.SubCategory)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasDefaultValueSql("(N'V009')");

        builder.Property(e => e.Updated).HasDefaultValueSql("((0))");

        builder.HasOne(d => d.CategoryNavigation)
            .WithMany(p => p.TaxesDats)
            .HasForeignKey(d => d.Category)
            .HasConstraintName("FK_TaxesDAT_Taxes_Group");

        builder.HasOne(d => d.SubCategoryNavigation)
            .WithMany(p => p.TaxesDats)
            .HasForeignKey(d => d.SubCategory)
            .HasConstraintName("FK_TaxesDAT_Taxes_SubGroup");
    }
}