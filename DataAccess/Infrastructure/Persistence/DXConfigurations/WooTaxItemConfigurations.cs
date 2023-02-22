using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WooTaxItemConfiguration : IEntityTypeConfiguration<WooTaxItem>
{


    public void Configure(EntityTypeBuilder<WooTaxItem> builder)
    {
        builder.ToTable("WooTaxItem");

        builder.HasIndex(e => e.WooOrderFeeLineid, "IX_WooTaxItem_WooOrderFeeLineid");

        builder.HasIndex(e => e.WooOrderLineItemid, "IX_WooTaxItem_WooOrderLineItemid");

        builder.HasIndex(e => e.WooOrderShippingLineid, "IX_WooTaxItem_WooOrderShippingLineid");

        builder.Property(e => e.Id)
            .HasColumnType("decimal(20, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Subtotal)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("subtotal");

        builder.Property(e => e.Total)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("total");

        builder.Property(e => e.WooOrderFeeLineid).HasColumnType("decimal(20, 0)");

        builder.Property(e => e.WooOrderLineItemid).HasColumnType("decimal(20, 0)");

        builder.Property(e => e.WooOrderShippingLineid).HasColumnType("decimal(20, 0)");

        builder.HasOne(d => d.WooOrderFeeLine)
            .WithMany(p => p.WooTaxItems)
            .HasForeignKey(d => d.WooOrderFeeLineid);

        builder.HasOne(d => d.WooOrderLineItem)
            .WithMany(p => p.WooTaxItems)
            .HasForeignKey(d => d.WooOrderLineItemid);

        builder.HasOne(d => d.WooOrderShippingLine)
            .WithMany(p => p.WooTaxItems)
            .HasForeignKey(d => d.WooOrderShippingLineid);
    }
}