using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TripHomeConfiguration : IEntityTypeConfiguration<TripHome>
{
    public void Configure(EntityTypeBuilder<TripHome> builder)
    {
        builder.HasNoKey();

        builder.ToTable("Trip_Home");

        builder.Property(e => e.ArrCity).HasMaxLength(50);

        builder.Property(e => e.ArrDt)
            .HasMaxLength(50)
            .HasColumnName("ArrDT");

        builder.Property(e => e.ArrGate).HasMaxLength(50);

        builder.Property(e => e.ArrTime)
            .HasMaxLength(50)
            .HasColumnName("ArrTIme");

        builder.Property(e => e.ArrTreminal).HasMaxLength(50);

        builder.Property(e => e.CancelFees).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.CarrierCode).HasMaxLength(5);

        builder.Property(e => e.ClassOfSeervice)
            .HasMaxLength(5)
            .HasColumnName("ClassOfSEervice");

        builder.Property(e => e.Commision).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.CommisionPerc).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.DepCity).HasMaxLength(50);

        builder.Property(e => e.DepDt)
            .HasMaxLength(50)
            .HasColumnName("DepDT");

        builder.Property(e => e.DepGate).HasMaxLength(50);

        builder.Property(e => e.DepTime)
            .HasMaxLength(50)
            .HasColumnName("DepTIme");

        builder.Property(e => e.DepTreminal).HasMaxLength(50);

        builder.Property(e => e.Fare).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.FileName).HasMaxLength(50);

        builder.Property(e => e.FlightNumber)
            .HasMaxLength(50)
            .HasColumnName("FLightNumber");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("id");

        builder.Property(e => e.IssueDate).HasColumnType("datetime");

        builder.Property(e => e.LocalAmount).HasMaxLength(50);

        builder.Property(e => e.LocalCurrency).HasMaxLength(50);

        builder.Property(e => e.Memo).HasMaxLength(50);

        builder.Property(e => e.NetAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.NetCurrency).HasMaxLength(50);

        builder.Property(e => e.OrginalTicket).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.PassMail).HasMaxLength(50);

        builder.Property(e => e.PassName).HasMaxLength(50);

        builder.Property(e => e.PassPhone).HasMaxLength(50);

        builder.Property(e => e.PassType).HasMaxLength(50);

        builder.Property(e => e.Pnr)
            .HasMaxLength(10)
            .HasColumnName("PNR");

        builder.Property(e => e.Routes).HasMaxLength(250);

        builder.Property(e => e.RoutesTime)
            .HasMaxLength(250)
            .HasColumnName("RoutesTIme");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Status).HasMaxLength(50);

        builder.Property(e => e.TcnNumber).HasMaxLength(50);

        builder.Property(e => e.TicketNumber).HasMaxLength(50);

        builder.Property(e => e.Total).HasMaxLength(50);

        builder.Property(e => e.TotalTax).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Ttype)
            .HasMaxLength(50)
            .HasColumnName("TType");

        builder.Property(e => e.Tx1).HasMaxLength(50);

        builder.Property(e => e.Tx1Name).HasMaxLength(50);

        builder.Property(e => e.Tx1Sign).HasMaxLength(50);

        builder.Property(e => e.Tx2).HasMaxLength(50);

        builder.Property(e => e.Tx2Name).HasMaxLength(50);

        builder.Property(e => e.Tx2Sign).HasMaxLength(50);

        builder.Property(e => e.Tx3).HasMaxLength(50);

        builder.Property(e => e.Tx3Name).HasMaxLength(50);

        builder.Property(e => e.Tx3Sign).HasMaxLength(50);

        builder.Property(e => e.UserCode).HasMaxLength(50);
    }
}