using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TripDemanding1Configuration : IEntityTypeConfiguration<TripDemanding1>
{
    public void Configure(EntityTypeBuilder<TripDemanding1> builder)
    {
        builder.HasNoKey();

        builder.ToView("TripDemanding");

        builder.Property(e => e.Amount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.EmdAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.EndDate).HasColumnType("datetime");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.Name).HasMaxLength(400);

        builder.Property(e => e.PeriodId).HasColumnName("PeriodID");

        builder.Property(e => e.PeriodName).HasMaxLength(4000);

        builder.Property(e => e.RefundAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.StartDate).HasColumnType("datetime");

        builder.Property(e => e.TicketAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.VoidAmount).HasColumnType("numeric(18, 5)");
    }
}