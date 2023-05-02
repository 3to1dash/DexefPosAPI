using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrTimeOffEntryConfiguration : IEntityTypeConfiguration<HrTimeOffEntry>
{
    public void Configure(EntityTypeBuilder<HrTimeOffEntry> builder)
    {
        builder.ToTable("Hr_TimeOFF_Entry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Amount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.BasicAmountPerc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ChangedAmountPerc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.FromAmount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TimeOffId).HasColumnName("TimeOffID");

        builder.Property(e => e.ToAmount).HasColumnType("numeric(19, 5)");
    }
}