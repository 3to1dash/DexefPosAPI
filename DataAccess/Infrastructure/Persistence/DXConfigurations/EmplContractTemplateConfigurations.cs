using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EmplContractTemplateConfiguration : IEntityTypeConfiguration<EmplContractTemplate>
{


    public void Configure(EntityTypeBuilder<EmplContractTemplate> builder)
    {
        builder.HasNoKey();

        builder.ToTable("EmplContractTemplate");

        builder.Property(e => e.AbsenceDayId).HasColumnName("AbsenceDayID");

        builder.Property(e => e.Active).HasDefaultValueSql("((1))");

        builder.Property(e => e.ArName).HasMaxLength(150);

        builder.Property(e => e.AttendPolicyId).HasColumnName("AttendPolicyID");

        builder.Property(e => e.ChName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.ContractTypeId).HasColumnName("ContractTypeID");

        builder.Property(e => e.DiscountAmountId).HasColumnName("DiscountAmountID");

        builder.Property(e => e.DiscountHourId).HasColumnName("DiscountHourID");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT")
            .HasDefaultValueSql("(getdate())");

        builder.Property(e => e.EnName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.ExtraAmountId).HasColumnName("ExtraAmountID");

        builder.Property(e => e.ExtraDayId).HasColumnName("ExtraDayID");

        builder.Property(e => e.ExtraHourId).HasColumnName("ExtraHourID");

        builder.Property(e => e.FrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");

        builder.Property(e => e.InsuranceId).HasColumnName("InsuranceID");

        builder.Property(e => e.ProductionId).HasColumnName("ProductionID");

        builder.Property(e => e.RoName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.RuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.SalesRepSliceId).HasColumnName("SalesRepSliceID");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.TuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Writtenby).HasMaxLength(50);
    }
}