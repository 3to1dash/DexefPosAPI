using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrFingerPrintSettingConfiguration : IEntityTypeConfiguration<HrFingerPrintSetting>
{
    public void Configure(EntityTypeBuilder<HrFingerPrintSetting> builder)
    {
        builder.ToTable("HR_FingerPrintSetting");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Active).HasDefaultValueSql("((1))");

        builder.Property(e => e.ArName).HasMaxLength(150);

        builder.Property(e => e.BaudRate).HasMaxLength(50);

        builder.Property(e => e.ChName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.ConnectMode).HasMaxLength(50);

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

        builder.Property(e => e.Incode)
            .HasMaxLength(50)
            .HasColumnName("INCode");

        builder.Property(e => e.Ip)
            .HasMaxLength(50)
            .HasColumnName("IP");

        builder.Property(e => e.OutCode).HasMaxLength(50);

        builder.Property(e => e.Port).HasMaxLength(50);

        builder.Property(e => e.RoName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.RsPort).HasMaxLength(50);

        builder.Property(e => e.RuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.TuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Writtenby).HasMaxLength(50);
    }
}