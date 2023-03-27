using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PriceNameConfiguration : IEntityTypeConfiguration<PriceName>
{
    public void Configure(EntityTypeBuilder<PriceName> builder)
    {
        builder.ToTable("price_name");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Price1)
            .HasMaxLength(50)
            .HasColumnName("price1");

        builder.Property(e => e.Price2)
            .HasMaxLength(50)
            .HasColumnName("price2");

        builder.Property(e => e.Price3)
            .HasMaxLength(50)
            .HasColumnName("price3");

        builder.Property(e => e.Price4)
            .HasMaxLength(50)
            .HasColumnName("price4");

        builder.Property(e => e.Price5)
            .HasMaxLength(50)
            .HasColumnName("price5");

        builder.Property(e => e.Price6)
            .HasMaxLength(50)
            .HasColumnName("price6");

        builder.Property(e => e.Price7)
            .HasMaxLength(50)
            .HasColumnName("price7");

        builder.Property(e => e.Price8)
            .HasMaxLength(50)
            .HasColumnName("price8");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}