using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TripDemandingConfiguration : IEntityTypeConfiguration<TripDemanding>
{


    public void Configure(EntityTypeBuilder<TripDemanding> builder)
    {
        builder.ToTable("Trip_Demanding");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.AllCount).HasDefaultValueSql("((0))");

        builder.Property(e => e.Amount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Done).HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.EmdAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.PeriodId).HasColumnName("PeriodID");

        builder.Property(e => e.RefundAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Sent).HasDefaultValueSql("((0))");

        builder.Property(e => e.TicketAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.VoidAmount).HasColumnType("numeric(18, 5)");
    }
}