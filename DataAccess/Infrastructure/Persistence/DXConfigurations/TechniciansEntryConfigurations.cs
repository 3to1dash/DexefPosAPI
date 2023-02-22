using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TechniciansEntryConfiguration : IEntityTypeConfiguration<TechniciansEntry>
{


    public void Configure(EntityTypeBuilder<TechniciansEntry> builder)
    {
        builder.ToTable("TechniciansEntry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.DamageId).HasColumnName("DamageID");

        builder.Property(e => e.TecId).HasColumnName("TecID");
    }
}