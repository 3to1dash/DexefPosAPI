using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ExpensesClassConfiguration : IEntityTypeConfiguration<ExpensesClass>
{


    public void Configure(EntityTypeBuilder<ExpensesClass> builder)
    {
        builder.ToTable("Expenses_Class");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.CostId).HasColumnName("CostID");

        builder.Property(e => e.MustCostId).HasColumnName("MustCostID");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Prefix).HasMaxLength(20);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(150);

        builder.Property(e => e.ShowCostCenter).HasDefaultValueSql("((0))");

        builder.Property(e => e.ShowTaxes).HasDefaultValueSql("((0))");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.TypeIndex).HasColumnName("TypeINdex");
    }
}