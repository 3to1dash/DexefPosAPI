using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrTimeOffConfiguration : IEntityTypeConfiguration<HrTimeOff>
{
    public void Configure(EntityTypeBuilder<HrTimeOff> builder)
    {
        builder.ToTable("Hr_TimeOFF");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Active).HasDefaultValueSql("((1))");

        builder.Property(e => e.ArName).HasMaxLength(150);

        builder.Property(e => e.ChName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.DeductFromTimeoff).HasDefaultValueSql("((1))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT")
            .HasDefaultValueSql("(getdate())");

        builder.Property(e => e.EnName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.FrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Maximum).HasColumnType("numeric(18, 9)");

        builder.Property(e => e.Minimum).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.MinimumRepeatTimes).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Period).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.RepeatTimeType).HasMaxLength(20);

        builder.Property(e => e.RoName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.RuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.SalaryId).HasColumnName("SalaryID");

        builder.Property(e => e.TimeOffId).HasColumnName("TimeOffID");

        builder.Property(e => e.TimeOffType).HasMaxLength(50);

        builder.Property(e => e.TuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UpdatedBy).HasMaxLength(50);

        builder.Property(e => e.UrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}