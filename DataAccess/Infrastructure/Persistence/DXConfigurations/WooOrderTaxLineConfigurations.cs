using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WooOrderTaxLineConfiguration : IEntityTypeConfiguration<WooOrderTaxLine>
{


    public void Configure(EntityTypeBuilder<WooOrderTaxLine> builder)
    {
        builder.ToTable("WooOrderTaxLine");

        builder.HasIndex(e => e.WooOrderid, "IX_WooOrderTaxLine_WooOrderid");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Compound).HasColumnName("compound");

        builder.Property(e => e.Label).HasColumnName("label");

        builder.Property(e => e.RateCode).HasColumnName("rate_code");

        builder.Property(e => e.RateId).HasColumnName("rate_id");

        builder.Property(e => e.RatePercent)
            .HasColumnType("decimal(18, 0)")
            .HasColumnName("rate_percent");

        builder.Property(e => e.ShippingTaxTotal)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("shipping_tax_total");

        builder.Property(e => e.TaxTotal)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("tax_total");

        builder.Property(e => e.WooOrderid).HasColumnType("decimal(20, 0)");

        builder.HasOne(d => d.WooOrder)
            .WithMany(p => p.WooOrderTaxLines)
            .HasForeignKey(d => d.WooOrderid);
    }
}