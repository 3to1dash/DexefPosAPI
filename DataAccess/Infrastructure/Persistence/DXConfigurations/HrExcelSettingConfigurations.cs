using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrExcelSettingConfiguration : IEntityTypeConfiguration<HrExcelSetting>
{
    public void Configure(EntityTypeBuilder<HrExcelSetting> builder)
    {
        builder.ToTable("HR_ExcelSetting");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Active).HasDefaultValueSql("((1))");

        builder.Property(e => e.ArName).HasMaxLength(150);

        builder.Property(e => e.ChName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.ColDealing).HasMaxLength(50);

        builder.Property(e => e.ColDt).HasMaxLength(50);

        builder.Property(e => e.ColEmpNum).HasMaxLength(50);

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

        builder.Property(e => e.InCode).HasMaxLength(50);

        builder.Property(e => e.OutCode).HasMaxLength(50);

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

        builder.Property(e => e.Writtenby).HasMaxLength(50);
    }
}