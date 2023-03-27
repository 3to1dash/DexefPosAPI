using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SmsalertConfiguration : IEntityTypeConfiguration<Smsalert>
{
    public void Configure(EntityTypeBuilder<Smsalert> builder)
    {
        builder.ToTable("SMSAlert");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.SettingId)
            .HasMaxLength(50)
            .HasColumnName("SettingID");

        builder.Property(e => e.SettingValue).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Smsid).HasColumnName("SMSID");

        builder.Property(e => e.Time).HasColumnType("datetime");

        builder.Property(e => e.WeekDay).HasMaxLength(50);
    }
}