using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EstimateDistributeConfiguration : IEntityTypeConfiguration<EstimateDistribute>
{


    public void Configure(EntityTypeBuilder<EstimateDistribute> builder)
    {
        builder.ToTable("Estimate_Distribute");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.EstimateId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("EstimateID");

        builder.Property(e => e.Kindid).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.LocalPrice).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.LocalTotal).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Price).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Qty).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rate).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.ShipId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ShipID");

        builder.Property(e => e.Total).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Unite).HasMaxLength(50);
    }
}