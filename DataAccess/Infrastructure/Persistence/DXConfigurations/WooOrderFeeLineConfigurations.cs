using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WooOrderFeeLineConfiguration : IEntityTypeConfiguration<WooOrderFeeLine>
{


    public void Configure(EntityTypeBuilder<WooOrderFeeLine> builder)
    {
        builder.ToTable("WooOrderFeeLine");

        builder.HasIndex(e => e.WooOrderid, "IX_WooOrderFeeLine_WooOrderid");

        builder.Property(e => e.Id)
            .HasColumnType("decimal(20, 0)")
            .HasColumnName("id");

        builder.Property(e => e.Name).HasColumnName("name");

        builder.Property(e => e.TaxClass).HasColumnName("tax_class");

        builder.Property(e => e.TaxStatus).HasColumnName("tax_status");

        builder.Property(e => e.Total)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("total");

        builder.Property(e => e.TotalTax)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("total_tax");

        builder.Property(e => e.WooOrderid).HasColumnType("decimal(20, 0)");

        builder.HasOne(d => d.WooOrder)
            .WithMany(p => p.WooOrderFeeLines)
            .HasForeignKey(d => d.WooOrderid);
    }
}