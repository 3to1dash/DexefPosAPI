using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailyopConfiguration : IEntityTypeConfiguration<Dailyop>
{
    public void Configure(EntityTypeBuilder<Dailyop> builder)
    {
        builder.HasNoKey();

        builder.ToTable("dailyop");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("id");

        builder.Property(e => e.Opid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("opid");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}