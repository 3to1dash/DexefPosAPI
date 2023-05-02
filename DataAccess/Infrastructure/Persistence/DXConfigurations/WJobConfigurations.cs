using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WJobConfiguration : IEntityTypeConfiguration<WJob>
{
    public void Configure(EntityTypeBuilder<WJob> builder)
    {
        builder.ToTable("w_Job");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.DayAbsent)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("day_absent");

        builder.Property(e => e.DayAward)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("day_award");

        builder.Property(e => e.DayHafe)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("day_hafe");

        builder.Property(e => e.DayQuarter)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("day_quarter");

        builder.Property(e => e.Hour)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("hour");

        builder.Property(e => e.Hour2)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("hour2");

        builder.Property(e => e.HourAdditional)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("hour_additional");

        builder.Property(e => e.HourHafe)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("hour_hafe");

        builder.Property(e => e.Job)
            .HasMaxLength(50)
            .HasColumnName("job");

        builder.Property(e => e.Maxsolfa)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("maxsolfa");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

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

        builder.Property(e => e.Vacation)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("vacation");

        builder.Property(e => e.VacationRelay).HasColumnName("vacation_relay");
    }
}