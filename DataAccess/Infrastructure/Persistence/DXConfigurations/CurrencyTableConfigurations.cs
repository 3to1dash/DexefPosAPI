using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CurrencyTableConfiguration : IEntityTypeConfiguration<CurrencyTable>
{
    public void Configure(EntityTypeBuilder<CurrencyTable> builder)
    {
        builder.ToTable("Currency_Table");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.ArName).HasMaxLength(50);

        builder.Property(e => e.ArNameCountry).HasMaxLength(50);

        builder.Property(e => e.ArNameSubName).HasMaxLength(50);

        builder.Property(e => e.ChName).HasMaxLength(50);

        builder.Property(e => e.ChNameCountry).HasMaxLength(50);

        builder.Property(e => e.ChNameSubName).HasMaxLength(50);

        builder.Property(e => e.CountryCode).HasMaxLength(5);

        builder.Property(e => e.EnName).HasMaxLength(50);

        builder.Property(e => e.EnNameCountry).HasMaxLength(50);

        builder.Property(e => e.EnNameSubName).HasMaxLength(50);

        builder.Property(e => e.FrName).HasMaxLength(50);

        builder.Property(e => e.FrNameCountry).HasMaxLength(50);

        builder.Property(e => e.FrNameSubName).HasMaxLength(50);

        builder.Property(e => e.RoName).HasMaxLength(50);

        builder.Property(e => e.RoNameCountry).HasMaxLength(50);

        builder.Property(e => e.RoNameSubName).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.RuName).HasMaxLength(50);

        builder.Property(e => e.RuNameCountry).HasMaxLength(50);

        builder.Property(e => e.RuNameSubName).HasMaxLength(50);

        builder.Property(e => e.Shortcut).HasMaxLength(50);

        builder.Property(e => e.TuName).HasMaxLength(50);

        builder.Property(e => e.TuNameCountry).HasMaxLength(50);

        builder.Property(e => e.TuNameSubName).HasMaxLength(50);

        builder.Property(e => e.Urname)
            .HasMaxLength(50)
            .HasColumnName("URName");

        builder.Property(e => e.UrnameCountry)
            .HasMaxLength(50)
            .HasColumnName("URNameCountry");

        builder.Property(e => e.UrnameSubName)
            .HasMaxLength(50)
            .HasColumnName("URNameSubName");
    }
}