using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SmsnotificationConfiguration : IEntityTypeConfiguration<Smsnotification>
{


    public void Configure(EntityTypeBuilder<Smsnotification> builder)
    {
        builder.ToTable("SMSNotification");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Balance).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.DealingValue).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.IsRun).HasDefaultValueSql("((0))");

        builder.Property(e => e.PatrolId).HasColumnName("PatrolID");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");
    }
}