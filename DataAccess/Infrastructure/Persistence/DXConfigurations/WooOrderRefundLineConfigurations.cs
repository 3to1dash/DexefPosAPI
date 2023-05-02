using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WooOrderRefundLineConfiguration : IEntityTypeConfiguration<WooOrderRefundLine>
{
    public void Configure(EntityTypeBuilder<WooOrderRefundLine> builder)
    {
        builder.ToTable("WooOrderRefundLine");

        builder.HasIndex(e => e.WooOrderid, "IX_WooOrderRefundLine_WooOrderid");

        builder.Property(e => e.Id)
            .HasColumnType("decimal(20, 0)")
            .HasColumnName("id");

        builder.Property(e => e.Reason).HasColumnName("reason");

        builder.Property(e => e.Total)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("total");

        builder.Property(e => e.WooOrderid).HasColumnType("decimal(20, 0)");

        builder.HasOne(d => d.WooOrder)
            .WithMany(p => p.WooOrderRefundLines)
            .HasForeignKey(d => d.WooOrderid);
    }
}