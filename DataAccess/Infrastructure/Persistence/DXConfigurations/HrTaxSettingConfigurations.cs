using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrTaxSettingConfiguration : IEntityTypeConfiguration<HrTaxSetting>
{


    public void Configure(EntityTypeBuilder<HrTaxSetting> builder)
    {
        builder.ToTable("HR_TaxSettings");

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

        builder.Property(e => e.ExemptionAmount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.FrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.RoName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.RuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.SalaryId).HasColumnName("SalaryID");

        builder.Property(e => e.TuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UpdatedBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Writtenby).HasMaxLength(50);
    }
}