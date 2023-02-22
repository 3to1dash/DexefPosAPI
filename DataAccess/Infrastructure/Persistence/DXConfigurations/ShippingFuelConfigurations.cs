using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ShippingFuelConfiguration : IEntityTypeConfiguration<ShippingFuel>
{


    public void Configure(EntityTypeBuilder<ShippingFuel> builder)
    {
        builder.ToTable("ShippingFuel");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Name)
            .HasMaxLength(150)
            .HasColumnName("name");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Value)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");
    }
}