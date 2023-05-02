using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DiscountItemConfiguration : IEntityTypeConfiguration<DiscountItem>
{
    public void Configure(EntityTypeBuilder<DiscountItem> builder)
    {
        builder.ToTable("DiscountItem");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Dt1).HasColumnType("datetime");

        builder.Property(e => e.Dt2).HasColumnType("datetime");

        builder.Property(e => e.InDealing).HasMaxLength(50);

        builder.Property(e => e.Name).HasMaxLength(150);

        builder.Property(e => e.Permissions).HasMaxLength(900);

        builder.Property(e => e.PriceLevels).HasMaxLength(500);

        builder.Property(e => e.PurchaseDiscount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SaleDiscount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Ship).HasMaxLength(50);

        builder.Property(e => e.UseQty).HasDefaultValueSql("((0))");
    }
}