using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrSettingConfiguration : IEntityTypeConfiguration<HrSetting>
{
    public void Configure(EntityTypeBuilder<HrSetting> builder)
    {
        builder.ToTable("HR_Settings");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.ArName).HasMaxLength(150);

        builder.Property(e => e.ArNameDesc).HasMaxLength(550);

        builder.Property(e => e.ChName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.ChNameDesc)
            .HasMaxLength(550)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.ColName).HasMaxLength(50);

        builder.Property(e => e.EnName).HasMaxLength(150);

        builder.Property(e => e.EnNameDesc).HasMaxLength(550);

        builder.Property(e => e.FrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.FrNameDesc)
            .HasMaxLength(550)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.IndexType).HasMaxLength(50);

        builder.Property(e => e.LinkedTable).HasMaxLength(50);

        builder.Property(e => e.ParentId)
            .HasColumnName("ParentID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RoName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.RoNameDesc)
            .HasMaxLength(550)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.RuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.RuNameDesc)
            .HasMaxLength(550)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.TuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.TuNameDesc)
            .HasMaxLength(550)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UrNameDesc)
            .HasMaxLength(550)
            .HasDefaultValueSql("('')");
    }
}