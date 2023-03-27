using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TripDateRangeConfiguration : IEntityTypeConfiguration<TripDateRange>
{
    public void Configure(EntityTypeBuilder<TripDateRange> builder)
    {
        builder.ToTable("Trip_DateRange");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.EndDate).HasColumnType("datetime");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.StartDate).HasColumnType("datetime");

        builder.Property(e => e.Used).HasDefaultValueSql("((0))");
    }
}