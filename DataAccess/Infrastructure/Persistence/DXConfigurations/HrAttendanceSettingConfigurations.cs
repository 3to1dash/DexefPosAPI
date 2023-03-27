using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrAttendanceSettingConfiguration : IEntityTypeConfiguration<HrAttendanceSetting>
{
    public void Configure(EntityTypeBuilder<HrAttendanceSetting> builder)
    {
        builder.ToTable("Hr_AttendanceSettings");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.ArName).HasMaxLength(150);

        builder.Property(e => e.ChName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.EnName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.FrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.RoName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.RuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.TuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");
    }
}