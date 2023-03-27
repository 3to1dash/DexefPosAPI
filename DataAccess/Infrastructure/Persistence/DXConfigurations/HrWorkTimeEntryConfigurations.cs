using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrWorkTimeEntryConfiguration : IEntityTypeConfiguration<HrWorkTimeEntry>
{
    public void Configure(EntityTypeBuilder<HrWorkTimeEntry> builder)
    {
        builder.ToTable("Hr_WorkTime_Entry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Period).HasColumnType("datetime");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TimeId).HasColumnName("TimeID");

        builder.Property(e => e.TimeType).HasMaxLength(50);
    }
}