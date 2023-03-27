using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class MaintenanceTaskConfiguration : IEntityTypeConfiguration<MaintenanceTask>
{
    public void Configure(EntityTypeBuilder<MaintenanceTask> builder)
    {
        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.DamgeId).HasColumnName("DamgeID");

        builder.Property(e => e.DeviceModel).HasMaxLength(50);

        builder.Property(e => e.DeviceSerial).HasMaxLength(50);

        builder.Property(e => e.DtDelivery).HasColumnType("datetime");

        builder.Property(e => e.DtReminder).HasColumnType("datetime");

        builder.Property(e => e.Isreminder).HasColumnName("ISReminder");

        builder.Property(e => e.ItemTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("ItemTaskID");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.MaintenanceId).HasColumnName("MaintenanceID");

        builder.Property(e => e.Priority).HasMaxLength(50);

        builder.Property(e => e.Status).HasMaxLength(50);

        builder.Property(e => e.Subject).HasMaxLength(200);

        builder.Property(e => e.TecId).HasColumnName("TecID");

        builder.Property(e => e.TimeDelivery).HasMaxLength(50);

        builder.Property(e => e.TimeReminder).HasMaxLength(50);

        builder.Property(e => e.UpdateBy).HasMaxLength(50);

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}