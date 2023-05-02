using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EmplSalariesSliceEntryConfiguration : IEntityTypeConfiguration<EmplSalariesSliceEntry>
{
    public void Configure(EntityTypeBuilder<EmplSalariesSliceEntry> builder)
    {
        builder.ToTable("Empl_SalariesSlice_Entry");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.Amount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.FromAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.SliceId).HasColumnName("SliceID");

        builder.Property(e => e.ToAmount).HasColumnType("numeric(18, 5)");
    }
}