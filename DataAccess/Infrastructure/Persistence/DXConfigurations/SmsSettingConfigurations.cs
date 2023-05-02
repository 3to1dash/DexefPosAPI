using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SmsSettingConfiguration : IEntityTypeConfiguration<SmsSetting>
{
    public void Configure(EntityTypeBuilder<SmsSetting> builder)
    {
        builder.ToTable("SMS_Setting");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Smsid).HasColumnName("SMSID");
    }
}