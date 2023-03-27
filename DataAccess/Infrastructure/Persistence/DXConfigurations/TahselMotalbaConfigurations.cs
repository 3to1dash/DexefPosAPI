using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TahselMotalbaConfiguration : IEntityTypeConfiguration<TahselMotalba>
{
    public void Configure(EntityTypeBuilder<TahselMotalba> builder)
    {
        builder.ToTable("tahsel_motalba");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Cashid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("cashid");

        builder.Property(e => e.Motalbaid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("motalbaid");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}