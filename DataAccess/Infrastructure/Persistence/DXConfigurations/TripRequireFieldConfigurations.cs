using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TripRequireFieldConfiguration : IEntityTypeConfiguration<TripRequireField>
{
    public void Configure(EntityTypeBuilder<TripRequireField> builder)
    {
        builder.ToTable("Trip_RequireFields");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AirLine).HasDefaultValueSql("((0))");

        builder.Property(e => e.Amount).HasDefaultValueSql("((0))");

        builder.Property(e => e.ArrPort).HasDefaultValueSql("((0))");

        builder.Property(e => e.DepPort).HasDefaultValueSql("((0))");

        builder.Property(e => e.Direction).HasDefaultValueSql("((0))");

        builder.Property(e => e.Fees).HasDefaultValueSql("((0))");

        builder.Property(e => e.FlightNumber).HasDefaultValueSql("((0))");

        builder.Property(e => e.Intrnational).HasDefaultValueSql("((0))");

        builder.Property(e => e.PaxAge).HasDefaultValueSql("((0))");

        builder.Property(e => e.PaxName).HasDefaultValueSql("((0))");

        builder.Property(e => e.PaxPhone).HasDefaultValueSql("((0))");

        builder.Property(e => e.Pnr)
            .HasColumnName("PNR")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SaleCommission).HasDefaultValueSql("((0))");

        builder.Property(e => e.Segment).HasDefaultValueSql("((0))");

        builder.Property(e => e.Ticket).HasMaxLength(50);
    }
}