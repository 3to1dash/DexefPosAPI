using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WooOrderShippingLineConfiguration : IEntityTypeConfiguration<WooOrderShippingLine>
{


    public void Configure(EntityTypeBuilder<WooOrderShippingLine> builder)
    {
        builder.ToTable("WooOrderShippingLine");

        builder.HasIndex(e => e.WooOrderid, "IX_WooOrderShippingLine_WooOrderid");

        builder.Property(e => e.Id)
            .HasColumnType("decimal(20, 0)")
            .HasColumnName("id");

        builder.Property(e => e.InstanceId).HasColumnName("instance_id");

        builder.Property(e => e.MethodId).HasColumnName("method_id");

        builder.Property(e => e.MethodTitle).HasColumnName("method_title");

        builder.Property(e => e.Total)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("total");

        builder.Property(e => e.TotalTax)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("total_tax");

        builder.Property(e => e.WooOrderid).HasColumnType("decimal(20, 0)");

        builder.HasOne(d => d.WooOrder)
            .WithMany(p => p.WooOrderShippingLines)
            .HasForeignKey(d => d.WooOrderid);
    }
}