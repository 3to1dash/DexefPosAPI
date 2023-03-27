using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EstimateShipConfiguration : IEntityTypeConfiguration<EstimateShip>
{
    public void Configure(EntityTypeBuilder<EstimateShip> builder)
    {
        builder.ToTable("EstimateShip");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CompanyShippingId).HasColumnName("CompanyShippingID");

        builder.Property(e => e.Dafter)
            .HasMaxLength(20)
            .HasColumnName("dafter");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.DtArrival).HasColumnType("datetime");

        builder.Property(e => e.Dthijri)
            .HasMaxLength(50)
            .HasColumnName("DTHijri");

        builder.Property(e => e.EstimateId).HasColumnName("EstimateID");

        builder.Property(e => e.ItemCount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Name)
            .HasMaxLength(250)
            .HasColumnName("name");

        builder.Property(e => e.Num).HasMaxLength(50);

        builder.Property(e => e.ShipDt).HasColumnType("datetime");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.UpdateBy).HasMaxLength(50);

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}