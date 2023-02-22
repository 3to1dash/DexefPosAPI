using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TableConfiguration : IEntityTypeConfiguration<Table>
{


    public void Configure(EntityTypeBuilder<Table> builder)
    {
        builder.HasNoKey();

        builder.ToView("Tables");

        builder.Property(e => e.CustName).HasMaxLength(400);

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.DtEndBooking).HasColumnType("datetime");

        builder.Property(e => e.DtStartBooking).HasColumnType("datetime");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.TimeEndBooking).HasMaxLength(50);

        builder.Property(e => e.TimeStartBooking).HasMaxLength(50);
    }
}