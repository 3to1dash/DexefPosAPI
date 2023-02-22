using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ResTableBookingEntryConfiguration : IEntityTypeConfiguration<ResTableBookingEntry>
{


    public void Configure(EntityTypeBuilder<ResTableBookingEntry> builder)
    {
        builder.ToTable("ResTableBookingEntry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BookingId).HasColumnName("BookingID");

        builder.Property(e => e.DtEndBooking).HasColumnType("datetime");

        builder.Property(e => e.DtStartBooking).HasColumnType("datetime");

        builder.Property(e => e.FloorId).HasColumnName("FloorID");

        builder.Property(e => e.FloorName).HasMaxLength(50);

        builder.Property(e => e.Isavailable).HasColumnName("ISAvailable");

        builder.Property(e => e.TableId).HasColumnName("TableID");

        builder.Property(e => e.TableName).HasMaxLength(50);
    }
}