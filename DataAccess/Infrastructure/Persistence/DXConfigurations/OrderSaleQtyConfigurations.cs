using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class OrderSaleQtyConfiguration : IEntityTypeConfiguration<OrderSaleQty>
{


    public void Configure(EntityTypeBuilder<OrderSaleQty> builder)
    {
        builder.ToTable("OrderSale_Qty");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .HasColumnName("dealing");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Invalue)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("invalue")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Kindid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("kindid");

        builder.Property(e => e.Note)
            .HasMaxLength(2000)
            .HasColumnName("note");

        builder.Property(e => e.Orderindex)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("orderindex");

        builder.Property(e => e.Outvalue)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("outvalue")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship)
            .HasMaxLength(50)
            .HasColumnName("ship");
    }
}