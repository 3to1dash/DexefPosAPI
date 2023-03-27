using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EstimateShipEntryConfiguration : IEntityTypeConfiguration<EstimateShipEntry>
{
    public void Configure(EntityTypeBuilder<EstimateShipEntry> builder)
    {
        builder.ToTable("EstimateShipEntry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Code).HasMaxLength(50);

        builder.Property(e => e.EstimateId).HasColumnName("EstimateID");

        builder.Property(e => e.EstimateQty).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ItemCost).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.Price).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.RemainQty).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ShipId).HasColumnName("ShipID");

        builder.Property(e => e.ShipQty).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.SpentCost).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Total).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TotalCost).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TotalSpent).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Unite).HasMaxLength(50);
    }
}