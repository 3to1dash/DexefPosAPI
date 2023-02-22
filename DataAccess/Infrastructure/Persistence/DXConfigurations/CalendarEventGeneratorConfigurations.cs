using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CalendarEventGeneratorConfiguration : IEntityTypeConfiguration<CalendarEventGenerator>
{


    public void Configure(EntityTypeBuilder<CalendarEventGenerator> builder)
    {
        builder.ToTable("Calendar_EventGenerator");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.FromTick).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Location).HasMaxLength(350);

        builder.Property(e => e.LocationArName).HasMaxLength(350);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Subject).HasMaxLength(250);

        builder.Property(e => e.SubjectArName).HasMaxLength(250);

        builder.Property(e => e.ToTick).HasColumnType("numeric(18, 0)");
    }
}