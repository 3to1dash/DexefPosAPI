using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WooOrderMetumConfiguration : IEntityTypeConfiguration<WooOrderMetum>
{


    public void Configure(EntityTypeBuilder<WooOrderMetum> builder)
    {
        builder.HasIndex(e => e.WooOrderFeeLineid, "IX_WooOrderMeta_WooOrderFeeLineid");

        builder.HasIndex(e => e.WooOrderLineItemid, "IX_WooOrderMeta_WooOrderLineItemid");

        builder.HasIndex(e => e.WooOrderShippingLineid, "IX_WooOrderMeta_WooOrderShippingLineid");

        builder.HasIndex(e => e.WooOrderTaxLineid, "IX_WooOrderMeta_WooOrderTaxLineid");

        builder.HasIndex(e => e.WooOrderid, "IX_WooOrderMeta_WooOrderid");

        builder.Property(e => e.Id)
            .HasColumnType("decimal(20, 0)")
            .HasColumnName("id");

        builder.Property(e => e.DisplayKey).HasColumnName("display_key");

        builder.Property(e => e.Key).HasColumnName("key");

        builder.Property(e => e.WooOrderFeeLineid).HasColumnType("decimal(20, 0)");

        builder.Property(e => e.WooOrderLineItemid).HasColumnType("decimal(20, 0)");

        builder.Property(e => e.WooOrderShippingLineid).HasColumnType("decimal(20, 0)");

        builder.Property(e => e.WooOrderid).HasColumnType("decimal(20, 0)");

        builder.HasOne(d => d.WooOrderFeeLine)
            .WithMany(p => p.WooOrderMeta)
            .HasForeignKey(d => d.WooOrderFeeLineid);

        builder.HasOne(d => d.WooOrderLineItem)
            .WithMany(p => p.WooOrderMeta)
            .HasForeignKey(d => d.WooOrderLineItemid);

        builder.HasOne(d => d.WooOrderShippingLine)
            .WithMany(p => p.WooOrderMeta)
            .HasForeignKey(d => d.WooOrderShippingLineid);

        builder.HasOne(d => d.WooOrderTaxLine)
            .WithMany(p => p.WooOrderMeta)
            .HasForeignKey(d => d.WooOrderTaxLineid);

        builder.HasOne(d => d.WooOrder)
            .WithMany(p => p.WooOrderMeta)
            .HasForeignKey(d => d.WooOrderid);
    }
}