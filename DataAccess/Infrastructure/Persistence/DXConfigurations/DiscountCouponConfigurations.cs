using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DiscountCouponConfiguration : IEntityTypeConfiguration<DiscountCoupon>
{


    public void Configure(EntityTypeBuilder<DiscountCoupon> builder)
    {
        builder.ToTable("DiscountCoupon");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Active).HasDefaultValueSql("((1))");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.MaxDiscount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.MinimumAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Perc).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Writtenby).HasMaxLength(50);
    }
}