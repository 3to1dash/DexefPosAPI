using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrPayrollScheduleConfiguration : IEntityTypeConfiguration<HrPayrollSchedule>
{


    public void Configure(EntityTypeBuilder<HrPayrollSchedule> builder)
    {
        builder.ToTable("Hr_PayrollSchedule");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Active).HasDefaultValueSql("((1))");

        builder.Property(e => e.ArName).HasMaxLength(150);

        builder.Property(e => e.ChName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT")
            .HasDefaultValueSql("(getdate())");

        builder.Property(e => e.EnName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.EndDt)
            .HasColumnType("datetime")
            .HasColumnName("EndDT");

        builder.Property(e => e.FrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Note).HasMaxLength(450);

        builder.Property(e => e.RoName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.RuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.ScheduleType).HasMaxLength(20);

        builder.Property(e => e.StartDt)
            .HasColumnType("datetime")
            .HasColumnName("StartDT");

        builder.Property(e => e.TuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Writtenby).HasMaxLength(50);
    }
}