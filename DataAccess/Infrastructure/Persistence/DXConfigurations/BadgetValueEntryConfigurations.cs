using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class BadgetValueEntryConfiguration : IEntityTypeConfiguration<BadgetValueEntry>
{


    public void Configure(EntityTypeBuilder<BadgetValueEntry> builder)
    {
        builder.ToTable("Badget_ValueEntry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BadgetValueId).HasColumnName("BadgetValueID");

        builder.Property(e => e.Caption).HasMaxLength(50);

        builder.Property(e => e.ExpectedValue).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.FromDt)
            .HasColumnType("datetime")
            .HasColumnName("FromDT");

        builder.Property(e => e.ToDt)
            .HasColumnType("datetime")
            .HasColumnName("ToDT");
    }
}