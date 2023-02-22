using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class MaintenanceAccessoriesEntryConfiguration : IEntityTypeConfiguration<MaintenanceAccessoriesEntry>
{


    public void Configure(EntityTypeBuilder<MaintenanceAccessoriesEntry> builder)
    {
        builder.ToTable("MaintenanceAccessoriesEntry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccessorieId).HasColumnName("AccessorieID");

        builder.Property(e => e.MaintenanceId).HasColumnName("MaintenanceID");
    }
}