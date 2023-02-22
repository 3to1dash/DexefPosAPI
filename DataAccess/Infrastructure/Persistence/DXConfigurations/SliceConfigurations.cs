using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SliceConfiguration : IEntityTypeConfiguration<Slice>
{


    public void Configure(EntityTypeBuilder<Slice> builder)
    {
        builder.ToTable("Slice");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AbsentId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("AbsentID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DayHalfId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("DayHalfID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DayQuartId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("DayQuartID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DistributeId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("DistributeID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ExtraDayId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ExtraDayID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ExtraHourId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ExtraHourID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.FactoreId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("FactoreID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.HalfHourId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("HalfHourID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.HasAttendance).HasDefaultValueSql("((1))");

        builder.Property(e => e.Hour2Id)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("Hour2ID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.HourId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("HourID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InstallmentId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("InstallmentID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.IsDiscount).HasDefaultValueSql("((1))");

        builder.Property(e => e.ItineraryId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ItineraryID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.MaxSolfaId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("MaxSolfaID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Num).HasColumnName("num");

        builder.Property(e => e.PledgeId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("PledgeID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Salary)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TimeExtra)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Timedelay)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("timedelay")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Timein)
            .HasColumnType("datetime")
            .HasColumnName("timein");

        builder.Property(e => e.Timeout)
            .HasColumnType("datetime")
            .HasColumnName("timeout");

        builder.Property(e => e.VacationDiscountId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("VacationDiscountID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.VacationRelay).HasColumnName("vacation_relay");

        builder.Property(e => e.WithoutLogOutId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("WithoutLogOutID")
            .HasDefaultValueSql("((0))");
    }
}