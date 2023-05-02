using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ResTableBookingConfiguration : IEntityTypeConfiguration<ResTableBooking>
{
    public void Configure(EntityTypeBuilder<ResTableBooking> builder)
    {
        builder.ToTable("ResTableBooking");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.DtEndBooking).HasColumnType("datetime");

        builder.Property(e => e.DtStartBooking).HasColumnType("datetime");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.TimeEndBooking).HasMaxLength(50);

        builder.Property(e => e.TimeStartBooking).HasMaxLength(50);

        builder.Property(e => e.UpdateBy).HasMaxLength(50);

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}