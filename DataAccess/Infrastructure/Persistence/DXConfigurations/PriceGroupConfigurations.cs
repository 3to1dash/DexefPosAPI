using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PriceGroupConfiguration : IEntityTypeConfiguration<PriceGroup>
{


    public void Configure(EntityTypeBuilder<PriceGroup> builder)
    {
        builder.HasNoKey();

        builder.ToTable("price_group");

        builder.Property(e => e.Detail)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("detail")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.EndDate)
            .HasColumnType("datetime")
            .HasColumnName("end_date");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("name")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.StDate)
            .HasColumnType("datetime")
            .HasColumnName("st_date");

        builder.Property(e => e.Value)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("value")
            .HasDefaultValueSql("((0))");
    }
}