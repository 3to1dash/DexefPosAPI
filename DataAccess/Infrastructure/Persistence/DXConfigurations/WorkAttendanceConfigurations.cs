using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkAttendanceConfiguration : IEntityTypeConfiguration<WorkAttendance>
{


    public void Configure(EntityTypeBuilder<WorkAttendance> builder)
    {
        builder.HasNoKey();

        builder.ToTable("work_attendance");

        builder.Property(e => e.Additional)
            .HasMaxLength(50)
            .HasColumnName("additional")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.AdditionalPrice)
            .HasColumnType("money")
            .HasColumnName("additional_price")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Attendance)
            .HasColumnName("attendance")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .HasColumnName("dealing")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Delay)
            .HasMaxLength(50)
            .HasColumnName("delay")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.DelayPrice)
            .HasColumnType("money")
            .HasColumnName("delay_price")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Leave)
            .HasColumnName("leave")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Period)
            .HasMaxLength(50)
            .HasColumnName("period")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TimeAttendance)
            .HasColumnType("datetime")
            .HasColumnName("time_attendance")
            .HasDefaultValueSql("('00:00:00')");

        builder.Property(e => e.TimeLeave)
            .HasColumnType("datetime")
            .HasColumnName("time_leave")
            .HasDefaultValueSql("('00:00:00')");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}