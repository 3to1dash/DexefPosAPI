using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WooOrderLineItemConfiguration : IEntityTypeConfiguration<WooOrderLineItem>
{


    public void Configure(EntityTypeBuilder<WooOrderLineItem> builder)
    {
        builder.ToTable("WooOrderLineItem");

        builder.HasIndex(e => e.WooOrderid, "IX_WooOrderLineItem_WooOrderid");

        builder.Property(e => e.Id)
            .HasColumnType("decimal(20, 0)")
            .HasColumnName("id");

        builder.Property(e => e.Name).HasColumnName("name");

        builder.Property(e => e.Price)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("price");

        builder.Property(e => e.ProductId)
            .HasColumnType("decimal(20, 0)")
            .HasColumnName("product_id");

        builder.Property(e => e.Quantity)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("quantity");

        builder.Property(e => e.Sku).HasColumnName("sku");

        builder.Property(e => e.Subtotal)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("subtotal");

        builder.Property(e => e.SubtotalTax)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("subtotal_tax");

        builder.Property(e => e.TaxClass).HasColumnName("tax_class");

        builder.Property(e => e.Total)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("total");

        builder.Property(e => e.TotalTax)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("total_tax");

        builder.Property(e => e.VariationId)
            .HasColumnType("decimal(20, 0)")
            .HasColumnName("variation_id");

        builder.Property(e => e.WooOrderid).HasColumnType("decimal(20, 0)");

        builder.HasOne(d => d.WooOrder)
            .WithMany(p => p.WooOrderLineItems)
            .HasForeignKey(d => d.WooOrderid);
    }
}