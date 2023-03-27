using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TodayDateConfiguration : IEntityTypeConfiguration<TodayDate>
{
    public void Configure(EntityTypeBuilder<TodayDate> builder)
    {
        builder.HasKey(e => e.Dt);

        builder.ToTable("TodayDate");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.Hijri).HasColumnType("datetime");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}