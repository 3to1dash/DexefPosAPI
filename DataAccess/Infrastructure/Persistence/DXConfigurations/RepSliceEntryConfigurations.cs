using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RepSliceEntryConfiguration : IEntityTypeConfiguration<RepSliceEntry>
{
    public void Configure(EntityTypeBuilder<RepSliceEntry> builder)
    {
        builder.ToTable("RepSlice_Entry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.CalcType).HasMaxLength(20);

        builder.Property(e => e.FromAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.IsPerc).HasMaxLength(5);

        builder.Property(e => e.Perc).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SliceId).HasColumnName("SliceID");

        builder.Property(e => e.ToAmount).HasColumnType("numeric(18, 5)");
    }
}