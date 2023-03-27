using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrContractTemplateConfiguration : IEntityTypeConfiguration<HrContractTemplate>
{
    public void Configure(EntityTypeBuilder<HrContractTemplate> builder)
    {
        builder.ToTable("Hr_ContractTemplate");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Active).HasDefaultValueSql("((1))");

        builder.Property(e => e.AdditionHourId).HasColumnName("AdditionHourID");

        builder.Property(e => e.ArName).HasMaxLength(150);

        builder.Property(e => e.ChName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.DedcutionHourId).HasColumnName("DedcutionHourID");

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

        builder.Property(e => e.InsuranceId).HasColumnName("InsuranceID");

        builder.Property(e => e.Note).HasMaxLength(750);

        builder.Property(e => e.PayScheduleId).HasColumnName("PayScheduleID");

        builder.Property(e => e.ProductionId).HasColumnName("ProductionID");

        builder.Property(e => e.RoName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.RuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.TuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.WorkingPolicyId).HasColumnName("WorkingPolicyID");

        builder.Property(e => e.Writtenby).HasMaxLength(50);
    }
}