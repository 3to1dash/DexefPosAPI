using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class MaintenanceEntryConfiguration : IEntityTypeConfiguration<MaintenanceEntry>
{
    public void Configure(EntityTypeBuilder<MaintenanceEntry> builder)
    {
        builder.ToTable("MaintenanceEntry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.ComplationRatio).HasDefaultValueSql("((0))");

        builder.Property(e => e.DamageId).HasColumnName("DamageID");

        builder.Property(e => e.MaintenanceId).HasColumnName("MaintenanceID");

        builder.Property(e => e.Note).HasMaxLength(200);

        builder.Property(e => e.Status).HasMaxLength(50);

        builder.Property(e => e.TecId)
            .HasColumnName("TecID")
            .HasDefaultValueSql("((0))");
    }
}