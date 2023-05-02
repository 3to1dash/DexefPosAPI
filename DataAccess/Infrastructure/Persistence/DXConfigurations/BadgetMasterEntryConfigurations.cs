using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class BadgetMasterEntryConfiguration : IEntityTypeConfiguration<BadgetMasterEntry>
{
    public void Configure(EntityTypeBuilder<BadgetMasterEntry> builder)
    {
        builder.ToTable("Badget_MasterEntry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Caption).HasMaxLength(50);

        builder.Property(e => e.FromDt)
            .HasColumnType("datetime")
            .HasColumnName("FromDT");

        builder.Property(e => e.MasterId).HasColumnName("MasterID");

        builder.Property(e => e.ToDt)
            .HasColumnType("datetime")
            .HasColumnName("ToDT");
    }
}