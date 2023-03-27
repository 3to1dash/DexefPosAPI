using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DiscountQtySliceConfiguration : IEntityTypeConfiguration<DiscountQtySlice>
{
    public void Configure(EntityTypeBuilder<DiscountQtySlice> builder)
    {
        builder.ToTable("DiscountQty_Slice");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Discount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.DiscountId).HasColumnName("DiscountID");

        builder.Property(e => e.FromQty).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.ToQty)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.HasOne(d => d.DiscountNavigation)
            .WithMany(p => p.DiscountQtySlices)
            .HasForeignKey(d => d.DiscountId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_DiscountQty_Slice_DiscountQty");
    }
}