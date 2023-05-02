using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SmsalertEntryConfiguration : IEntityTypeConfiguration<SmsalertEntry>
{
    public void Configure(EntityTypeBuilder<SmsalertEntry> builder)
    {
        builder.ToTable("SMSAlert_Entry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AlertId).HasColumnName("AlertID");

        builder.Property(e => e.CustId).HasColumnName("CustID");
    }
}