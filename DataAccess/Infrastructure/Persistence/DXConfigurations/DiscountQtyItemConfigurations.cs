using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DiscountQtyItemConfiguration : IEntityTypeConfiguration<DiscountQtyItem>
{
    public void Configure(EntityTypeBuilder<DiscountQtyItem> builder)
    {
        builder.ToTable("DiscountQty_Items");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.DiscountId).HasColumnName("DiscountID");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.QtyIn)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.QtyOut)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TotalOutQty)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Unite).HasMaxLength(50);

        builder.Property(e => e.UniteQty)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.HasOne(d => d.Discount)
            .WithMany(p => p.DiscountQtyItems)
            .HasForeignKey(d => d.DiscountId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_DiscountQty_Items_DiscountQty");
    }
}