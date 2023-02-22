using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CustDiscountConfiguration : IEntityTypeConfiguration<CustDiscount>
{


    public void Configure(EntityTypeBuilder<CustDiscount> builder)
    {
        builder.ToTable("Cust_Discount");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.CanEdit).HasDefaultValueSql("((0))");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Discount)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("discount");

        builder.Property(e => e.DiscountId).HasColumnName("DiscountID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}