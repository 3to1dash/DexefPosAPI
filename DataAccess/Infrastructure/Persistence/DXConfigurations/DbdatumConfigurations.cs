using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DbdatumConfiguration : IEntityTypeConfiguration<Dbdatum>
{
    public void Configure(EntityTypeBuilder<Dbdatum> builder)
    {
        builder.ToTable("DBData");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Dbname)
            .HasMaxLength(50)
            .HasColumnName("DBName");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}