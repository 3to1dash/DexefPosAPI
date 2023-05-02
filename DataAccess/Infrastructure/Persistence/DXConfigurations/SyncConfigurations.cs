using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SyncConfiguration : IEntityTypeConfiguration<Sync>
{
    public void Configure(EntityTypeBuilder<Sync> builder)
    {
        builder.ToTable("Sync");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.CmpName).HasMaxLength(50);

        builder.Property(e => e.LastUpdate).HasColumnType("datetime");

        builder.Property(e => e.TargetDataBase).HasMaxLength(150);

        builder.Property(e => e.TargetServer).HasMaxLength(150);
    }
}