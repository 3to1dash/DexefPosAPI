using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ImportCostConfiguration : IEntityTypeConfiguration<ImportCost>
{
    public void Configure(EntityTypeBuilder<ImportCost> builder)
    {
        builder.ToTable("ImportCost");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Address).HasMaxLength(50);

        builder.Property(e => e.BankFeeOn).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.BankFeePercentage).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.CustomsCurrency).HasMaxLength(50);

        builder.Property(e => e.CustomsPerUnit).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.CustomsPercent).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Date).HasColumnType("datetime");

        builder.Property(e => e.Description).HasMaxLength(50);

        builder.Property(e => e.DutyFeeAmount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.DutyFeeCurrency).HasMaxLength(50);

        builder.Property(e => e.DutyFeeRate).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.DutyManAmount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.DutyManCurrency).HasMaxLength(50);

        builder.Property(e => e.DutyManPercent).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.DutyManRate).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.FileNo).HasMaxLength(50);

        builder.Property(e => e.Fobcurrency)
            .HasMaxLength(50)
            .HasColumnName("FOBCurrency");

        builder.Property(e => e.Fobrate)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("FOBRate");

        builder.Property(e => e.Fobvalue)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("FOBValue");

        builder.Property(e => e.HealthAmount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.HealthCurrency).HasMaxLength(50);

        builder.Property(e => e.HealthRate).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Importer).HasMaxLength(50);

        builder.Property(e => e.InsuranceCurrency).HasMaxLength(50);

        builder.Property(e => e.InsuranceRate).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.InsuranceValue).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.JaleelPercent).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.LocalCarryFeeAmount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.LocalCarryFeeCurrency).HasMaxLength(50);

        builder.Property(e => e.LocalCarryFeeRate).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.MainCurrency).HasMaxLength(50);

        builder.Property(e => e.OtherBankFeeAmount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.OtherBankFeeCurrency).HasMaxLength(50);

        builder.Property(e => e.OtherBankFeeRate).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.OtherCostAmount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.OtherCostCurrency).HasMaxLength(50);

        builder.Property(e => e.OtherCostRate).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.OtherDutyCurrency).HasMaxLength(50);

        builder.Property(e => e.OtherDutyName).HasMaxLength(50);

        builder.Property(e => e.OtherDutyValue).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.OtherPortFeeAmount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.OtherPortFeeCurrency).HasMaxLength(50);

        builder.Property(e => e.OtherPortFeeRate).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.PortFeeCurrency).HasMaxLength(50);

        builder.Property(e => e.PortFeeRate).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.PortFeeValue).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.PurchaseDutyCurrency).HasMaxLength(50);

        builder.Property(e => e.PurchaseDutyPerUnit).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.PurchaseDutyPercent).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.PurchaseDutyRate).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Quantity).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.QuantityCost).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.QuantityUnit).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TelFaxCostAmount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TelFaxCostCurrency).HasMaxLength(50);

        builder.Property(e => e.TelFaxCostRate).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TransportCurrency).HasMaxLength(50);

        builder.Property(e => e.TransportRate).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TransportValue).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.UnitCost).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Vatrate1)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("VATRate1");

        builder.Property(e => e.Vatrate2)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("VATRate2");
    }
}