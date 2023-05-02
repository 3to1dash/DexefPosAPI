using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WooOrderCouponLineMetumConfiguration : IEntityTypeConfiguration<WooOrderCouponLineMetum>
{
    public void Configure(EntityTypeBuilder<WooOrderCouponLineMetum> builder)
    {
        builder.HasIndex(e => e.WooOrderCouponLineid, "IX_WooOrderCouponLineMeta_WooOrderCouponLineid");

        builder.Property(e => e.Id)
            .HasColumnType("decimal(20, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.DisplayKey).HasColumnName("display_key");

        builder.Property(e => e.Key).HasColumnName("key");

        builder.Property(e => e.WooOrderCouponLineid).HasColumnType("decimal(20, 0)");

        builder.HasOne(d => d.WooOrderCouponLine)
            .WithMany(p => p.WooOrderCouponLineMeta)
            .HasForeignKey(d => d.WooOrderCouponLineid);
    }
}