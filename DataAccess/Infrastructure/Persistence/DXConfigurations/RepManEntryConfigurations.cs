using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RepManEntryConfiguration : IEntityTypeConfiguration<RepManEntry>
{


    public void Configure(EntityTypeBuilder<RepManEntry> builder)
    {
        builder.ToTable("RepMan_Entry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Perc).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.RepId).HasColumnName("RepID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.WorkId).HasColumnName("WorkID");
    }
}