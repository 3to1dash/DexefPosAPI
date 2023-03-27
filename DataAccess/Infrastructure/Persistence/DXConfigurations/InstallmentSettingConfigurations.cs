using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class InstallmentSettingConfiguration : IEntityTypeConfiguration<InstallmentSetting>
{
    public void Configure(EntityTypeBuilder<InstallmentSetting> builder)
    {
        builder.ToTable("Installment_Settings");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.CalcWay).HasDefaultValueSql("((0))");

        builder.Property(e => e.IncomePerc).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.MinInvoicePerc).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SendSms).HasColumnName("SendSMS");

        builder.Property(e => e.Sms)
            .HasMaxLength(500)
            .HasColumnName("SMS");

        builder.Property(e => e.Smsprovidor).HasColumnName("SMSProvidor");
    }
}