using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrInsuranceSettingConfiguration : IEntityTypeConfiguration<HrInsuranceSetting>
{
    public void Configure(EntityTypeBuilder<HrInsuranceSetting> builder)
    {
        builder.ToTable("HR_InsuranceSettings");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.Active).HasDefaultValueSql("((1))");

        builder.Property(e => e.ArName).HasMaxLength(150);

        builder.Property(e => e.BasicCompany).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.BasicEmployee).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.BasicMaximum).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.BasicTotal).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ChName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.ChangedCompany).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ChangedEmployee).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ChangedMaximum).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ChangedTotal).HasColumnType("numeric(19, 5)");

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

        builder.Property(e => e.UrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Writtenby).HasMaxLength(50);
    }
}