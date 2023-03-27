using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TaskMapAppointmentConfiguration : IEntityTypeConfiguration<TaskMapAppointment>
{
    public void Configure(EntityTypeBuilder<TaskMapAppointment> builder)
    {
        builder.HasKey(e => e.UniqueId);

        builder.ToTable("TaskMap_Appointments");

        builder.Property(e => e.CustomField1).HasMaxLength(2000);

        builder.Property(e => e.Description).HasMaxLength(2000);

        builder.Property(e => e.EndDate).HasColumnType("smalldatetime");

        builder.Property(e => e.Location).HasMaxLength(2000);

        builder.Property(e => e.RecurrenceInfo).HasMaxLength(2000);

        builder.Property(e => e.ReminderInfo).HasMaxLength(2000);

        builder.Property(e => e.ResourceIds).HasMaxLength(2000);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.StartDate).HasColumnType("smalldatetime");

        builder.Property(e => e.Subject).HasMaxLength(2000);

        builder.Property(e => e.TimeZoneId).HasMaxLength(2000);
    }
}