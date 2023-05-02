using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailyQuotumConfiguration : IEntityTypeConfiguration<DailyQuotum>
{
    public void Configure(EntityTypeBuilder<DailyQuotum> builder)
    {
        builder.ToTable("daily_quota");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Custid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("custid");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Kindid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("kindid");

        builder.Property(e => e.Regnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("regnum");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Unite)
            .HasMaxLength(50)
            .HasColumnName("unite");

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("value");
    }
}