using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WooOrderCouponLineConfiguration : IEntityTypeConfiguration<WooOrderCouponLine>
{


    public void Configure(EntityTypeBuilder<WooOrderCouponLine> builder)
    {
        builder.ToTable("WooOrderCouponLine");

        builder.HasIndex(e => e.WooOrderid, "IX_WooOrderCouponLine_WooOrderid");

        builder.Property(e => e.Id)
            .HasColumnType("decimal(20, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Code).HasColumnName("code");

        builder.Property(e => e.Discount)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("discount");

        builder.Property(e => e.DiscountTax)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("discount_tax");

        builder.Property(e => e.WooOrderid).HasColumnType("decimal(20, 0)");

        builder.HasOne(d => d.WooOrder)
            .WithMany(p => p.WooOrderCouponLines)
            .HasForeignKey(d => d.WooOrderid);
    }
}