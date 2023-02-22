using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EstimateEntryConfiguration : IEntityTypeConfiguration<EstimateEntry>
{


    public void Configure(EntityTypeBuilder<EstimateEntry> builder)
    {
        builder.ToTable("Estimate_Entry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Code)
            .HasMaxLength(150)
            .HasColumnName("code");

        builder.Property(e => e.Currency)
            .HasMaxLength(10)
            .IsFixedLength();

        builder.Property(e => e.EstimateId).HasColumnName("EstimateID");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.LocalPrice).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.LocalTotal).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Price).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Qty).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rate).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Total).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Unite).HasMaxLength(150);

        builder.Property(e => e.UsedQty)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");
    }
}